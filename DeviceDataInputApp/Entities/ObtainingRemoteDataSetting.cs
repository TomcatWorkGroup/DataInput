namespace DeviceDataInputApp.Entities
{
    public class ObtainingRemoteDataSetting
    {
        public const string SectionName = "ObtainingRemoteDataSetting";
        public string URL { get; set; }
        private int interval;
        public int Timing { get { return interval; } set { interval = value * 1000; } }
    }
}
