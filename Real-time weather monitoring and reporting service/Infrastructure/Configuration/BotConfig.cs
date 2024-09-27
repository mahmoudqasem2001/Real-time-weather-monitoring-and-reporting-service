using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Infrastructure.Configuration
{
    public class BotConfig
    {
        public bool Enabled { get; set; }
        public double Threshold { get; set; }
        public string Message { get; set; }
    }

    public class ConfigRoot
    {
        public BotConfig RainBot { get; set; }
        public BotConfig SunBot { get; set; }
        public BotConfig SnowBot { get; set; }
    }
}
