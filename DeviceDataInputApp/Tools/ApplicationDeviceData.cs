using DeviceDataInputApp.Entities;
using System.Collections.Generic;

namespace DeviceDataInputApp.Tools
{
    /// <summary>
    /// 全局存储数据
    /// </summary>
    public class ApplicationDeviceData
    {
        /// <summary>
        /// 全局存储通过URL获取到的数据
        /// </summary>
        private static Dictionary<string, string> dic = new Dictionary<string, string>();

        public static string GetDeviceNickName(string deviceNo)
        {
            return dic[deviceNo];
        }

        public static bool HaveTheDevice(string deviceNo)
        {
            return dic.ContainsKey(deviceNo);
        }

        public static void InitDevice(IList<DeviceSnapshot> devices)
        {
            lock (dic)
            {
                dic.Clear();
                foreach(var d in devices)
                {
                    dic.Add(d.deviceNo, d.nickName);
                }
            }
        }
    }
}
