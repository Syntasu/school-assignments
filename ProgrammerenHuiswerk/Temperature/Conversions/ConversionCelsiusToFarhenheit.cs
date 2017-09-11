using System;

namespace ProgrammerenHuiswek.Temperature.Conversions
{
    public class ConversionCelsiusToFarhenheit : ITemperatureConversion
    {
        public TemperatureUnit SourceUnit => TemperatureUnit.Celsius;
        public TemperatureUnit DestinationUnit => TemperatureUnit.Farhenheit;


        public double Convert(double input)
        {
            return input * 1.8 + 32;
        }

        public double ConvertWithWindChill(double input, double wind)
        {
            return Convert(TemperatureMath.CalculateWindChill(input, SourceUnit, wind));
        }

    }
}
