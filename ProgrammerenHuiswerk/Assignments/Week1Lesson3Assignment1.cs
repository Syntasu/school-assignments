using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson3Assignment1 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 3;
        public string AssignmentId => "1";

        public override void Execute()
        {
            Output.Add("Voer de getallen in waarvan je de grootste getal wil selecteren.");
            Output.Add("Zorg er voor dat de getallen gescheiden zijn met een comma");

            AssignmentHelper.RequestInput(this, "Voer de getallen in waarvan je de grootste getal wil selecteren.", out string input);
            string[] split = input.Split(',');

            int[] values = Array.ConvertAll(split, int.Parse);

            int highestValue = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > highestValue)
                {
                    highestValue = values[i];
                }
            }

            Output.Add("");
            Output.Add($"De hoogste waarde is {highestValue}");
        }
    }
}
