namespace ProgrammerenHuiswek.Temperature.Conversions
{
    public class ConversionFarhenheitToCelsius : ITemperatureConversion
    {
        public TemperatureUnit SourceUnit => TemperatureUnit.Farhenheit;
        public TemperatureUnit DestinationUnit => TemperatureUnit.Celsius;

        public double Convert(double input)
        {
            return (input - 32) / 1.8;
        }

        public double ConvertWithWindChill(double input, double wind)
        {
            return Convert(TemperatureMath.CalculateWindChill(input, SourceUnit, wind));
        }
    }
}
