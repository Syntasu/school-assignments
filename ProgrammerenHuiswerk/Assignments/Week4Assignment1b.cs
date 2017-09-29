using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week4Assignment1b : BaseRunable, IWeekProvider, IMultipleAssignmentsProvider
    {
        public int Week => 4;

        public string[] AssignmentIds => new[] { "1.3", "1.4", "1.5" };

        public override void Execute()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(100, 1000);

            int sumA = SumOfSeries(0, 100);
            int sumB = SumOfSeries(0, randomNumber);
            int sumC = SumOfSeries(9, 15);

            Output.Add($"De som van de reeks van 0 tot en met 100 is {sumA}");
            Output.Add($"De som van de reeks van 0 tot en met {randomNumber} is {sumB}");
            Output.Add($"De som van de reeks van 9 tot en met 15 is {sumC}");
        }

        public int SumOfSeries(int start, int end)
        {
            return (end - start + 1) * (end + start) / 2;
        }
    }
}
