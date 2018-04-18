using DeviceDataInputApp.Entities;
using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;
using DeviceDataInputApp.Tools;

namespace DeviceDataInputApp.Controllers
{
    public class DeviceController : Controller
    {
        public static string JSON;
        public RabbitMQSetting config;
        private ILog log;

        public DeviceController(IOptions<RabbitMQSetting> option)
        {
            config = option.Value;
            log = LogManager.GetLogger(Startup.repository.Name, typeof(DeviceController));
        }

        [HttpPost]
        public void DeviceDataInput()
        {
            try
            {
                var stream = Request.Body;
                byte[] bt = new byte[1024];
                int length = Request.Body.Read(bt, 0, bt.Length);
                string deviceNo = Encoding.ASCII.GetString(bt, 0, 20).ToString().Trim();
                //Dictionary<string, string> dictionary = Application<DeviceCollectionEntity>.DictionaryList;
                //if (null == dictionary)
                //{
                //    return;
                //}
                //*************************************************************              
                //if (!dictionary.ContainsKey(deviceNo))               
                //{
                //    return;
                //}
                //string _nickName = dictionary[deviceNo];
                if (!ApplicationDeviceData.HaveTheDevice(deviceNo))
                {
                    return;
                }
                string _nickName = ApplicationDeviceData.GetDeviceNickName(deviceNo);
                //*********************************************************
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    /*使用默认方式，不更改元数据的key的大小写*/
                    ContractResolver = new DefaultContractResolver()
                };
                NJZJDeviceRunEntity deviceRunEntity = Tools.ByteAdapter<NJZJDeviceRunEntity>.GetData(bt, 20);
                deviceRunEntity.setDeviceNo(deviceNo);
                deviceRunEntity.setNickName(_nickName);
                string json = JsonConvert.SerializeObject(deviceRunEntity, settings);
                ConnectionFactory factory = GetMQFactory();
                SendMsg(json, factory);
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
            }
        }
        private ConnectionFactory GetMQFactory()
        {
            return new ConnectionFactory
            {
                UserName = config.UserName,
                Password = config.Password,
                VirtualHost = config.VirtualHost,
                HostName = config.HostName,
                Port = config.Port
            };
        }
        private void SendMsg(byte[] data, ConnectionFactory factory)
        {
            using (IConnection conn = factory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
                    //var messageBodyBytes = Encoding.UTF8.GetBytes(json);
                    channel.BasicPublish(config.Exchange, config.RoutingKey.ByteKey, true, null, data);
                    //JSON = json;
                }
            }
        }
        private void SendMsg(string json, ConnectionFactory factory)
        {
            using (IConnection conn = factory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
                    var messageBodyBytes = Encoding.UTF8.GetBytes(json);
                    channel.BasicPublish(config.Exchange, config.RoutingKey.JsonKey, true, null, messageBodyBytes);
                    JSON = json;
                }
            }
        }
        [HttpPost]
        public void DataInput()
        {
            //var bytes = ReadBodyData();
            var bytes = new byte[1024];
            var length = Request.Body.Read(bytes, 0, bytes.Length);

            if (20 < length)
            {
                string deviceNo = Encoding.ASCII.GetString(bytes, 0, 20).ToString().Trim();
                if (!ApplicationDeviceData.HaveTheDevice(deviceNo))
                {
                    return;
                }
                string nickName = ApplicationDeviceData.GetDeviceNickName(deviceNo);
                SendMsg(bytes, GetMQFactory());
            }
        }

        private byte[] ReadBodyData()
        {
            var bt = new byte[1024];
            var length = Request.Body.Read(bt, 0, bt.Length);
            return bt;
        }
    }
}