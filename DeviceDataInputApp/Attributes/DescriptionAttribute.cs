using System;

namespace DeviceDataInputApp.Attributes
{
    public class DescriptionAttribute : Attribute
    {      
        public string Name { get; set; }       
        public string Unit { get; set; }
    }
}
