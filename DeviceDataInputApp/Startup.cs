using DeviceDataInputApp.Entities;
using DeviceDataInputApp.Tools;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;

namespace DeviceDataInputApp
{
    public class Startup
    {
        public static ILoggerRepository repository { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            repository = LogManager.CreateRepository("NETCoreRepository");
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddOptions();
            services.Configure<RabbitMQSetting>(Configuration.GetSection(RabbitMQSetting.SectionName));
            services.Configure<ObtainingRemoteDataSetting>(Configuration.GetSection(ObtainingRemoteDataSetting.SectionName));
            //services.AddSingleton<ApplicationDeviceData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IOptions<ObtainingRemoteDataSetting> option)
        {
            ObtainingRemoteDataSetting configSetting = option.Value;
            ObtainingRemoteData.REQUEST_URL = configSetting.URL;

            var thread = new Thread(()=> {
                while (true)
                {
                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(ObtainingRemoteData.REQUEST_URL);
                    webRequest.Method = "GET";
                    HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                    StreamReader sr = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                    var jsonText = sr.ReadToEnd();
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<DeviceSnapshot>));
                    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonText)))
                    {
                        var list = (List<DeviceSnapshot>)serializer.ReadObject(ms);
                        ApplicationDeviceData.InitDevice(list);
                    }
                  
                    Thread.Sleep(configSetting.Timing);
                }
            });
            thread.IsBackground = true;
            thread.Start();
            //new ObtainingRemoteData().GetDeviceCollectionData();
            //new TimedJob(configSetting.Timing).TriggerJob<ObtainingRemoteData>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
