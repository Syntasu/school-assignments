using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson2Assignment3 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 2;
        public string AssignmentId => "3";

        public override void Execute()
        {
            double length = 1.0;
            double wristCircumference = 1.0;

            ConsoleKey gender = AssignmentHelper.RequestKey(
                "Wat is je geslacht?",
                new[] { ConsoleKey.M, ConsoleKey.F}
            );

            AssignmentHelper.RequestInput(this, "Hoe lang ben je? (in cm)", out double height);

            int ideal = 0;
            if (gender == ConsoleKey.M)
            {
                ideal = Convert.ToInt32(height - 100);
            }
            else if (gender == ConsoleKey.F)
            {
                AssignmentHelper.RequestInput(this, "Wat is je pols omtrek? (in cm)", out double circumference);
                ideal = Convert.ToInt32((length + 4.0 * wristCircumference - 100) / 2);
            }
            else
            {
                Error = "Onbekend geslacht...";
            }

            Output.Add("");
            Output.Add($"Je ideale gewicht is {ideal} kg");
        }
    }
}
