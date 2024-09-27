using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Application.UseCases
{
    public class WeatherMonitoringService
    {
        private readonly List<IWeatherBot> _bots = new List<IWeatherBot>();

        public void RegisterBot(IWeatherBot bot)
        {
            _bots.Add(bot);
        }

        public void NotifyBots(WeatherData data)
        {
            foreach (var bot in _bots)
            {
                bot.Activate(data);
            }
        }
    }
}
