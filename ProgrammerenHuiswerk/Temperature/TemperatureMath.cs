using System;

namespace ProgrammerenHuiswek.Temperature
{
    public static class TemperatureMath
    {
        // Calculates the wind chill based on the wind in km/hour and temperature in celsius.
        public static double CalculateWindChill(double temperature, TemperatureUnit temperatureType, double wind)
        {
            double tempInCelsius = temperature;

            //Dont convert from celsius to celsius.
            if (temperatureType != TemperatureUnit.Celsius)
            {
                tempInCelsius = TemperatureConverter.Convert(temperature, temperatureType, TemperatureUnit.Celsius);
            }

            return 13.12 + 0.6215 * tempInCelsius - 11.37 * Math.Pow(wind, 0.16) + 0.3965 * tempInCelsius * Math.Pow(wind, 0.16);
        }
    }
}
