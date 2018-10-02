using System.Configuration;

namespace Spartan.RabbitMq.Config.Config
{
    public sealed class RabbitMqConfig : ConfigurationSection
    {
        [ConfigurationProperty("username", DefaultValue = "user", IsRequired = true)]
        public string Username => this["username"] as string;

        [ConfigurationProperty("password", DefaultValue = "password", IsRequired = true)]
        public string Password => this["password"] as string;

        [ConfigurationProperty("hostName", DefaultValue = "hostName", IsRequired = true)]
        public string HostName => this["hostName"] as string;

        [ConfigurationProperty("virtualHost", DefaultValue = "virtualHost", IsRequired = true)]
        public string VirtualHost => this["virtualHost"] as string;

        [ConfigurationProperty("port", DefaultValue = 5672, IsRequired = true)]
        public int Port => int.Parse(this["port"].ToString());
    }
}
