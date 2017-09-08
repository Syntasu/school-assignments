using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProgrammerenHuiswek.Temperature
{
    public static class TemperatureParser
    {
        public static Tuple<TemperatureUnit, double> Parse(string input)
        {
            TemperatureUnit currentUnit = TemperatureUnit.Unknown;

            char[] inputArray = input.ToCharArray();
            List<char> valueArray = new List<char>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                // Check if the current character is a valid enum.
                // If this is a valid unit, we set the current unit type.
                if (Enum.IsDefined(typeof (TemperatureUnit), (byte)inputArray[i]))
                {
                    currentUnit = (TemperatureUnit)inputArray[i];
                    continue;
                }

                // Check if the current character is a decimal digit or dot or comma used in decimals/doubles.
                if (char.IsDigit(inputArray[i]) || inputArray[i] == '.' || inputArray[i] == ',')
                {
                    valueArray.Add(inputArray[i]);
                }
            }

            string rawValue = new string(valueArray.ToArray());
            double value = double.Parse(rawValue, CultureInfo.InvariantCulture);

            return new Tuple<TemperatureUnit, double>(currentUnit, value);
        }
    }
}
