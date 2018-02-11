using System;

namespace DeviceDataInputApp.Tools
{
    /// <summary>
    /// Byte数据处理中心
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ByteAdapter<T> where T : class, new()
    {
        public static T GetData(byte[] data, int dataByteStartIndex)
        {
            T entity = new T();
            Type type = entity.GetType();
            var members = type.GetMethods();
            bool isInit = false;
            foreach (var m in members)
            {
                int num = 0;
                var attr = Attribute.GetCustomAttribute(m, typeof(Attributes.ByteAttribute));
                if (null == attr)
                {
                    continue;
                }
                Attributes.ByteAttribute battr = attr as Attributes.ByteAttribute;
                if (battr.StartIndex > dataByteStartIndex)
                {
                    if (battr.Length == 1)
                    {
                        num = data[battr.StartIndex];
                    }
                    else
                    {
                        num = data[battr.StartIndex];
                        num += data[battr.StartIndex + 1] << 8;
                    }
                    m.Invoke(entity, new object[] { num });
                    isInit = true;
                }
            }
            return isInit ? entity : null;
        }
    }
}
