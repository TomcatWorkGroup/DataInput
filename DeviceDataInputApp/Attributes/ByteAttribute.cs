using System;

namespace DeviceDataInputApp.Attributes
{
    public class ByteAttribute : Attribute
    {
        /// <summary>
        /// 开始字节
        /// </summary>
        public int StartIndex { get; set; }
        /// <summary>
        /// 字节长度
        /// </summary>
        public int Length { get; set; }
    }
}
