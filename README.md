# Real-Time Weather Monitoring and Reporting Service

## Overview

This C# console application simulates a **real-time weather monitoring and reporting service**. It can receive weather data in different formats (JSON and XML) and respond accordingly by activating pre-configured "weather bots." These bots are activated based on certain thresholds like temperature and humidity, and their behavior is configurable through a JSON file.

## Features

- Supports multiple input formats (JSON and XML) for weather data.
- Configurable weather bots (`RainBot`, `SunBot`, `SnowBot`) that activate based on temperature and humidity conditions.
- Easy-to-modify bot behavior via configuration file.
- Follows SOLID principles, particularly Open-Closed principle, for adding new bots or input formats.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

## Project Structure

/WeatherMonitoringApp │ ├── /Core │ ├── Entities │ └── Interfaces │ ├── /Application │ └── UseCases │ ├── /Adapters │ ├── Bots │ └── Parsers │ ├── /Infrastructure │ └── IO │ └── /UI └── Program.cs


- **Core**: Contains entities like `WeatherData` and interfaces such as `IWeatherBot`.
- **Application**: Contains the weather monitoring service use case.
- **Adapters**: Implements the various weather bots and parsers (JSON and XML).
- **Infrastructure**: Handles configuration loading and other external dependencies.
- **UI**: Main entry point for the application.

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/yourusername/Real-time-weather-monitoring-and-reporting-service.git
cd Real-time-weather-monitoring-and-reporting-service
