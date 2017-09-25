using ProgrammerenHuiswerk.Framework;
using System.Globalization;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson1Assignment5 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string AssignmentId => "5";

        public override void Execute()
        {
            const double DollarRate = 1.2231;

            AssignmentHelper.RequestInput(this, "Hoeveel euro wil je omzetten naar USD?", out string input);

            if (double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out double euros))
            {
                double usdConverted = euros * DollarRate;
                Output.Add("");
                Output.Add($"{euros} EUR is gelijk aan {usdConverted} USD");
            }
        }
    }
}
