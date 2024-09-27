using Newtonsoft.Json;
using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Adapters.Parsers
{
    public class JsonWeatherParser : IWeatherParser
    {
        public WeatherData Parse(string input)
        {
            return JsonConvert.DeserializeObject<WeatherData>(input);
        }
    }
}
