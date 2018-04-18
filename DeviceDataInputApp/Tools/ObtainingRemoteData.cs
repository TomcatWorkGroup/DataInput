using DeviceDataInputApp.Entities;
using Quartz;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System;
using log4net;

namespace DeviceDataInputApp.Tools
{
    /// <summary>
    /// 通过URL获取数据
    /// </summary>
    public class ObtainingRemoteData : IJob
    {
        /// <summary>
        /// 远程数据请求地址
        /// </summary>
        public static string REQUEST_URL;
        private ILog log;
        public ObtainingRemoteData()
        {
            log = LogManager.GetLogger(Startup.repository.Name, typeof(ObtainingRemoteData));
        }
        //异步操作
        public async Task Execute(IJobExecutionContext context)
        {
            Console.Out.WriteLine("触发定时任务..............");
            await new Task(() => { GetDeviceCollectionData(); });
        }
        /// <summary>
        /// 获取远程请求设备名称数据集
        /// </summary>
        public void GetDeviceCollectionData()
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(REQUEST_URL);
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
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
            }
        }

    }
}
