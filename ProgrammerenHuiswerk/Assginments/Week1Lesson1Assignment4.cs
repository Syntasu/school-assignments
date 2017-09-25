using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment4 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string AssignmentId => "4";

        public override void Execute()
        {
            Output.Add("Q: Wat zijn de verschillen tussen float en double type (zoek het op internet) en geef een duidelijk voorbeeld waarin je de verschillen tussen de typen kan zien.");
            Output.Add("");
            Output.Add("A:\n De precisie is het verschil tussen double and float.\nFloat is bekend als \"single percision\", float gebruiken 32 bits\nDouble is bekend als \"double percision\", dubbel de percisie en dus 64 bits.\nOok hebben we decimal, die gebruikt 128 bits.\nOm het verschil te zien kunnen we de datatypes uitprinten en het zal laten zien dat hoe hoger de precisie is, hoe meer decimalen de waarde heeft.");
            Output.Add("");


            //32 bits (7 decimals)
            float a = 1f / 3;

            //64 bits (16 decimals)
            double b = 1d / 3;

            //128 bits (32 decimals);
            decimal c = 1m / 3;

            Output.Add("Voorbeelden:");
            Output.Add($"Float waarde: {a}");
            Output.Add($"Double waarde: {b}");
            Output.Add($"Decimal waarde: {c}");
        }
    }
}
