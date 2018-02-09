using DeviceDataInputApp.Entities;
using System.Collections.Generic;

namespace DeviceDataInputApp.Tools
{
    /// <summary>
    /// 全局存储数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class Application<T> where T : class, new()
    {
        /// <summary>
        /// 全局存储通过URL获取到的数据
        /// </summary>
        public static Dictionary<string,string> DictionaryList { get; set; }
        /// <summary>
        /// 全局存储配置文件的请求路径
        /// </summary>
        public static string URL { get; set; }
        /// <summary>
        /// 全局存储配置文件的定时时间
        /// </summary>
        public static int Timing { get; set; }
    }
}
