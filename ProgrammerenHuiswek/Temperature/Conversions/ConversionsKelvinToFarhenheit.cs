using System;

namespace ProgrammerenHuiswek.Temperature.Conversions
{
    public class ConversionsKelvinToFarhenheit : ITemperatureConversion
    {
        public TemperatureUnit SourceUnit => TemperatureUnit.Kelvin;
        public TemperatureUnit DestinationUnit => TemperatureUnit.Farhenheit;

        public double Convert(double input)
        {
            return input * 9 / 5 - 459.67;
        }

        public double ConvertWithWindChill(double input, double wind)
        {
            return Convert(TemperatureMath.CalculateWindChill(input, SourceUnit, wind));
        }
    }
}
