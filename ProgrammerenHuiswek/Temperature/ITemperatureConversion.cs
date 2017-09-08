namespace ProgrammerenHuiswek.Temperature
{
    public interface ITemperatureConversion
    {
        TemperatureUnit SourceUnit { get; }
        TemperatureUnit DestinationUnit { get; }

        double Convert(double input);
        double ConvertWithWindChill(double input, double wind); 
    }
}
