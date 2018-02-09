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
        private ILog log;
        public ObtainingRemoteData()
        {
            log = LogManager.GetLogger(Startup.repository.Name, typeof(ObtainingRemoteData));
        }      
        //异步操作
        public async Task Execute(IJobExecutionContext context)
        {
            this.GetDeviceCollectionData();
            await Console.Out.WriteLineAsync("Start Obtain URL Data Job" + DateTime.Now.ToString("yyyyMMddHHmmss"));
        }
        /// <summary>
        /// 获取远程请求设备名称数据集
        /// </summary>
        public void GetDeviceCollectionData()
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(Application<object>.URL);
                webRequest.Method = "GET";
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                StreamReader sr = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                var jsonText = sr.ReadToEnd();
                IList<DeviceCollectionEntity> list;
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<DeviceCollectionEntity>));
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonText)))
                {
                    list = (List<DeviceCollectionEntity>)serializer.ReadObject(ms);
                }
                Dictionary<string, string> dictionary = new Dictionary<string,string>();
                foreach (DeviceCollectionEntity model in list)
                {
                    dictionary.Add(model.deviceNo,model.nickName);
                }
                Application<DeviceCollectionEntity>.DictionaryList = dictionary;
            }
            catch (Exception ex)
            {
                var error = ex.Message;//测试=》获取程序错误的信息
                log.Info(ex.ToString());
            }
        }
    }
}
