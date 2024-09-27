using Newtonsoft.Json;
using Real_time_weather_monitoring_and_reporting_service.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Infrastructure.IO
{
    public class ConfigurationReader
    {
        public static ConfigRoot LoadConfig(string filePath)
        {
            string configJson = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<ConfigRoot>(configJson);
        }
    }
}
