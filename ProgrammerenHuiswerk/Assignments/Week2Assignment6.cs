using ProgrammerenHuiswerk.Framework;
using System.Linq;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week2Assignment6 : BaseRunable, IWeekProvider, ISingleAssignmentProvider
    {
        public int Week => 2;
        public string AssignmentId => "6";

        public override void Execute()
        {
            int days = 7;
            int weeks = 4;
            int[,] temperatures =
            {
                { 15, 1,  2,  0,  20, 5,  7 },
                { 6,  3,  0,  8,  9,  15, 7 },
                { 2,  3,  5,  7,  8,  9,  10},
                { 11, 13, 16, 13, 15, 11, 7 },
            };

            double[] weekAverages = new double[weeks];
            for (int w = 0; w < weeks; w++)
            {
                int sum = 0;
                for (int d = 0; d < days; d++)
                {
                    sum += temperatures[w, d];
                }

                double average = sum / days;
                Output.Add($"De gemiddelde temperatuur voor week {w + 1} is {average}");

                weekAverages[w] = average;
            }

            double monthAverage = weekAverages.Sum() / weeks;
            Output.Add($"De gemiddelde temperatuur van deze maand is {monthAverage}");
        }
    }
}
