using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Adapters.Bots
{
    public class SnowBot : IWeatherBot
    {
        private readonly double _temperatureThreshold;
        private readonly string _message;

        public SnowBot(double temperatureThreshold, string message)
        {
            _temperatureThreshold = temperatureThreshold;
            _message = message;
        }

        public void Activate(WeatherData data)
        {
            if (data.Temperature < _temperatureThreshold)
            {
                Console.WriteLine("SnowBot activated!");
                Console.WriteLine(_message);
            }
        }
    }
}
