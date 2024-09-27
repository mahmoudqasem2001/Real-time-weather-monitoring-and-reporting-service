using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Adapters.Bots
{
    public class SunBot : IWeatherBot
    {
        private readonly double _temperatureThreshold;
        private readonly string _message;

        public SunBot(double temperatureThreshold, string message)
        {
            _temperatureThreshold = temperatureThreshold;
            _message = message;
        }

        public void Activate(WeatherData data)
        {
            if (data.Temperature > _temperatureThreshold)
            {
                System.Console.WriteLine("SunBot activated!");
                System.Console.WriteLine(_message);
            }
        }
    }
}
