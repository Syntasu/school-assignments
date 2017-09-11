using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerenHuiswek.Temperature.Conversions
{
    public class ConversionFarhenheitToKelvin : ITemperatureConversion
    {
        public TemperatureUnit SourceUnit => TemperatureUnit.Farhenheit;
        public TemperatureUnit DestinationUnit => TemperatureUnit.Kelvin;

        public double Convert(double input)
        {
            return (input + 459.67) * 5 / 9;
        }

        public double ConvertWithWindChill(double input, double wind)
        {
            return Convert(TemperatureMath.CalculateWindChill(input, SourceUnit, wind));
        }
    }
}
