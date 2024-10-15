using Real_time_weather_monitoring_and_reporting_service.Adapters.Bots;
using Real_time_weather_monitoring_and_reporting_service.Adapters.Parsers;
using Real_time_weather_monitoring_and_reporting_service.Application.UseCases;
using Real_time_weather_monitoring_and_reporting_service.Core.Entities;
using Real_time_weather_monitoring_and_reporting_service.Core.Interfaces;
using Real_time_weather_monitoring_and_reporting_service.Infrastructure.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_weather_monitoring_and_reporting_service
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationReader.LoadConfig("C:\\Users\\HP\\Desktop\\botConfig.json");

            var service = new WeatherMonitoringService();

            if (config.RainBot.Enabled)
                service.RegisterBot(new RainBot(config.RainBot.Threshold, config.RainBot.Message));

            if (config.SunBot.Enabled)
                service.RegisterBot(new SunBot(config.SunBot.Threshold, config.SunBot.Message));

            if (config.SnowBot.Enabled)
                service.RegisterBot(new SnowBot(config.SnowBot.Threshold, config.SnowBot.Message));

            Console.WriteLine("Enter weather data (JSON or XML):");
            string input = Console.ReadLine();

            IWeatherParser parser = input.TrimStart().StartsWith("{") ? (IWeatherParser)new JsonWeatherParser() : new XmlWeatherParser();
            WeatherData weatherData = parser.Parse(input);

            service.NotifyBots(weatherData);
        }
    }
}
