using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service.Core.Interfaces
{
    public interface IWeatherBot
    {
        void Activate(WeatherData data);
    }
}
