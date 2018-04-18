namespace DeviceDataInputApp.Entities
{
    public class RabbitMQSetting
    {
        public const string SectionName = "RabbitMQSetting";
        public string HostName { get; set; }
        public string VirtualHost { get; set; }
        public int Port { get; set; }
        public string Exchange { get; set; }
        public RoutingKey RoutingKey { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class RoutingKey
    {
        public string JsonKey { get; set; }
        public string ByteKey { get; set; }
    }
}
