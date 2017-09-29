using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week2Assignment3 : BaseRunable, IWeekProvider, ISingleAssignmentProvider
    {
        public int Week => 2;
        public string AssignmentId => "3";

        public override void Execute()
        {
            Output.Add("Voer de getallen in waarbij alleen de oneven getallen geprint worden.");
            Output.Add("Zorg er voor dat de getallen gescheiden zijn met een comma");
            ShowOutput();

            AssignmentHelper.RequestInput(
                this,
                "Voer de getallen in:",
                out string numbers
            );

            string[] split = numbers.Split(',');
            int[] values = Array.ConvertAll(split, int.Parse);

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    Output.Add($"{values[i]} is een even getal");
                }
            }
        }
    }
}
