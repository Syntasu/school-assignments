using System;
using System.Linq;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week2
    {
        public Week2()
        {
            Opgave6();
        }

        private void Opgave6()
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

            int[] weekAverages = new int[weeks];
            for (int w = 0; w < weeks; w++)
            {
                int sum = 0;
                for (int d = 0; d < days; d++)
                {
                    sum += temperatures[w, d];
                }

                int average = sum / days;
                WriteLine($"De gemiddelde temperatuur voor week {w+1} is {average}");

                weekAverages[w] = average;
            }

            int monthAverage = weekAverages.Sum() / weeks;
            WriteLine($"De gemiddelde temperatuur van deze maand is {monthAverage}");
        }
    }
}
