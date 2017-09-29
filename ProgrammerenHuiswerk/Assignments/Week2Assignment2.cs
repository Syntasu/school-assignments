
using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week2Assignment2 : BaseRunable, IWeekProvider, ISingleAssignmentProvider
    {
        public int Week => 2;
        public string AssignmentId => "2";

        public override void Execute()
        {
            Output.Add("De invoer moet gescheiden zijn met een comma.");
            ShowOutput();

            AssignmentHelper.RequestInput(
                this,
                "Voer de getallen in die je wilt gebruiken.",
                out string input
             );

            string[] split = input.Split(',');
            int[] values = Array.ConvertAll(split, int.Parse);

            AssignmentHelper.RequestInput(
                this,
                $"Welke index wil je opvragen? (van 0 tot {values.Length - 1})",
                out int index
            );

            if (index < 0)
            {
                Error = "Kan index lager als 0 niet opvragen.";
                return;
            }

            if(index > values.Length)
            {
                Error = "Kan index niet opvragen.";
                return;
            }

            Output.Add($"De waarde van index {index} is {values[index]}");
        }
    }
}
