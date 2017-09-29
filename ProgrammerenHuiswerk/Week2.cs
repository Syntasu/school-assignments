using System;
using System.Linq;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week2
    {
        public Week2()
        {
            Opgave5();
            Opgave6();
        }

        #region Opgave 5
        private void Opgave5()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- WEEK 2 OPGAVE 5 ---\n");

            WriteLine("Hoeveel leerlingen wil je toevoegen?");
            string inputSize = ReadLine();
            int.TryParse(inputSize, out int size);

            string[] students = new string[size];

            for (int i = 0; i < size; i++)
            {
                WriteLine("Wat is de naam van de leerling?");
                string leerlingName = ReadLine();

                students[i] = leerlingName;
            }

            string names = String.Join(", ", students);
            WriteLine($"In totaal hebben we {size} leerlingen met de namen: {names}");
        }
        #endregion

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
