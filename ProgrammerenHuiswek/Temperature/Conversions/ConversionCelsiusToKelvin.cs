namespace ProgrammerenHuiswek.Temperature.Conversions
{
    public class ConversionCelsiusToKelvin : ITemperatureConversion
    {
        public TemperatureUnit SourceUnit => TemperatureUnit.Celsius;
        public TemperatureUnit DestinationUnit => TemperatureUnit.Kelvin;

        public double Convert(double input)
        {
            return input + 273.15;
        }

        public double ConvertWithWindChill(double input, double wind)
        {
            return Convert(TemperatureMath.CalculateWindChill(input, SourceUnit, wind));
        }
    }
}
