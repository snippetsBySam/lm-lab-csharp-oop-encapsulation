using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string Location;
        private double TemperatureInCelcius;

        public WeatherReporter(string location, double temperatureInCelcius) =>
            (Location, TemperatureInCelcius) = (location, temperatureInCelcius);

        private double CelcuisToF(double temperatureInCelcius) => (9.0 / 5.0) * temperatureInCelcius + 32;
        public string WeatherReport()
        {
            return $"I am in {Location} and it is {GetWeather()}. {GetFeeling()}. The temperature in Fahrenheit is {CelcuisToF(TemperatureInCelcius)}°F.";
        }

        public string GetWeather()
        {
            switch (Location)
            {
                case "London":
                    return "🌦";

                case "California":
                    return "🌅";

                case "Cape Town":
                    return "🌤";

                default:
                    return "🔆";
            }
        }

        public string GetFeeling()
        {
            switch (TemperatureInCelcius)
            {
                case > 30:
                    return "It's too hot 🥵!";

                case < 10:
                    return "It's too cold 🥶!";

                default:
                    return "Ahhh...it's just right 😊!";
            }
        }
        
    }
}

