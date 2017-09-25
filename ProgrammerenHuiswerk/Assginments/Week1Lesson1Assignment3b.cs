using System;
using ProgrammerenHuiswerk.Framework;
using ProgrammerenHuiswek.Temperature;
using System.Text;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson1Assignment3b : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string AssignmentId => "3b";

        public override void Execute()
        {
            bool calculateWindChill = false;
            double windSpeed = 0.0;

            //Tell the user which options are available.
            Output.Add("--------------------------------------------------------------");
            Output.Add("Temperatuur types: F (Farhenheit), C (Celsius), K (Kelvin).");
            Output.Add("Zet de letter achter het nummer, hoofdletters maakt niet uit.");
            Output.Add("--------------------------------------------------------------");

            //Ask the user which value he wants to use for the conversion
            AssignmentHelper.RequestInput(
                this, 
                "Voer de temperatuur in die je wilt gebruiken. (bijv. 20.0C of 25.6F)", 
                out string inputString
            );

            bool parsed = TemperatureParser.Parse(inputString, out TemperatureUnit inputUnit, out double inputValue);

            if(!parsed)
            {
                Error = $"Kan waarde `{inputString}` niet conventeren naar een double.";
                return;
            }

            if(inputUnit == TemperatureUnit.Unknown)
            {
                Error = $"Onbekende temperatuur type!";
                return;
            }
     
            // Ask the user which type he wants to convert to.
            bool targetUnitSuccess = AssignmentHelper.RequestInput(
                this, 
                "Naar welk temperatuur type wil je het conveteren (F/C/K)?", 
                out char targeUnitResult
            );

            if(!targetUnitSuccess)
            {
                Error = "Kan input niet converteren naar goede type.";
                return;
            }

            TemperatureUnit targetUnit = (TemperatureUnit)targeUnitResult;

            if (inputUnit.Equals(targetUnit))
            {
                Error = $"De conversie is het zelfde (van {inputUnit} naar {targetUnit})";
                return;
            }

            ConsoleKey key = AssignmentHelper.RequestKey(
                "Wil je ook het gevoelstemperatuur berekenen?",
                new[] { ConsoleKey.Y, ConsoleKey.N }
            );

            if(key == ConsoleKey.Y)
            {
                AssignmentHelper.RequestInput<double>(
                    this, 
                    "Wat is de wind snelheid in kilometer per seconde?", 
                    out windSpeed
                );

                calculateWindChill = true;
            }
            else if(key == ConsoleKey.N)
            {
                calculateWindChill = false;
            }
            else
            {
                Error = "De ingevoerde toets is incorrect.";
                return;
            }

            //Lookup conversion, print result
            double result = TemperatureConverter.Convert(inputValue, inputUnit, targetUnit);
            double resultRounded = Math.Round(result, 2);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine($"Het gegeven temperatuur was {inputValue} {inputUnit}, omgezet is het resultaat: {result} {targetUnit}");
            builder.AppendLine("");

            //Append the results of the wind chill calculations.
            if (calculateWindChill)
            {
                double resultWindChill = TemperatureConverter.ConvertInclWindChill(inputValue, windSpeed, inputUnit, targetUnit);
                double resultWindChillRounded = Math.Round(resultWindChill, 2);

                builder.AppendLine($"Het gevoelstemperatuur met een windsnelheid van {windSpeed} km/h is {resultWindChillRounded} {targetUnit} \n");
            }

            //Write out the entire result.
            Output.Add(builder.ToString());
            Output.Add("Oant moan!");
        }
    }
}
