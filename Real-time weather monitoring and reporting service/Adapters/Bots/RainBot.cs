using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Adapters.Bots
{
    public class RainBot : IWeatherBot
    {
        private readonly double _humidityThreshold;
        private readonly string _message;

        public RainBot(double humidityThreshold, string message)
        {
            _humidityThreshold = humidityThreshold;
            _message = message;
        }

        public void Activate(WeatherData data)
        {
            if (data.Humidity > _humidityThreshold)
            {
                System.Console.WriteLine("RainBot activated!");
                System.Console.WriteLine(_message);
            }
        }
    }
}
