using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Real_time_weather_monitoring_and_reporting_service.Adapters.Parsers
{
    public class XmlWeatherParser : IWeatherParser
    {
        public WeatherData Parse(string input)
        {
            XElement xElement = XElement.Parse(input);
            return new WeatherData
            {
                Location = xElement.Element("Location")?.Value,
                Temperature = double.Parse(xElement.Element("Temperature")?.Value),
                Humidity = double.Parse(xElement.Element("Humidity")?.Value)
            };
        }
    }
}
