using System;

namespace ProgrammerenHuiswek.Temperature.Conversions
{
    public class ConversionKelvinToCelsius : ITemperatureConversion
    {
        public TemperatureUnit SourceUnit => TemperatureUnit.Kelvin;
        public TemperatureUnit DestinationUnit => TemperatureUnit.Celsius;

        public double Convert(double input)
        {
            return input - 273.15;
        }

        public double ConvertWithWindChill(double input, double wind)
        {
            return Convert(TemperatureMath.CalculateWindChill(input, SourceUnit, wind));
        }
    }
}
