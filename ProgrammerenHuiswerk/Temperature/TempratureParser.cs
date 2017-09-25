using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProgrammerenHuiswek.Temperature
{
    public static class TemperatureParser
    {
        public static bool Parse(string input, out TemperatureUnit unit, out double value)
        {
            unit = TemperatureUnit.Unknown;
            value = 0.0;

            if (input.Length < 0) return false;

            TemperatureUnit currentUnit = TemperatureUnit.Unknown;

            char[] inputArray = input.ToLower().ToCharArray();
            List<char> valueArray = new List<char>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                // Check if the current character is a valid enum.
                // If this is a valid unit, we set the current unit type.
                if (Enum.IsDefined(typeof(TemperatureUnit), (byte)inputArray[i]))
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
            bool hasConverted = double.TryParse(rawValue, NumberStyles.Number, CultureInfo.InvariantCulture, out double result);

            if(hasConverted)
            {
                value = result;
                unit = currentUnit;
                return true;
            }

            return false;
        }
    }
}