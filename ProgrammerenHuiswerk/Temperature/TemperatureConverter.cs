using ProgrammerenHuiswek.Temperature.Conversions;
using System;
using System.Collections.Generic;

namespace ProgrammerenHuiswek.Temperature
{
    public static class TemperatureConverter
    {
        private static IList<ITemperatureConversion> conversions = new List<ITemperatureConversion>();

        static TemperatureConverter()
        {
            //Define all the conversion methods.
            conversions.Add(new ConversionCelsiusToFarhenheit());
            conversions.Add(new ConversionCelsiusToKelvin());
            conversions.Add(new ConversionFarhenheitToCelsius());
            conversions.Add(new ConversionFarhenheitToKelvin());
            conversions.Add(new ConversionKelvinToCelsius());
            conversions.Add(new ConversionsKelvinToFarhenheit());
        }

        public static double Convert(double value, TemperatureUnit source, TemperatureUnit dest)
        {
            //Lookup conversion method with correct source and destination unit.
            foreach (ITemperatureConversion conv in conversions)
            {
                if(conv.SourceUnit == source && conv.DestinationUnit == dest)
                {
                    return conv.Convert(value);
                }
            }

            Console.WriteLine("Could not find correct conversion method");
            return 0.0f;
        }

        public static double ConvertInclWindChill(double value, double wind, TemperatureUnit source, TemperatureUnit dest)
        {
            //Lookup conversion method with correct source and destination unit.
            foreach (ITemperatureConversion conv in conversions)
            {
                if (conv.SourceUnit == source && conv.DestinationUnit == dest)
                {
                    return conv.ConvertWithWindChill(value, wind);
                }
            }

            Console.WriteLine("Could not find correct conversion method");
            return 0.0f;
        }
    }
}
