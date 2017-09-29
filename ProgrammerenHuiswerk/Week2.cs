using System;
using System.Linq;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week2
    {
        public Week2()
        {
            Opgave2();
            Opgave3();
            Opgave4();
            Opgave5();
            Opgave6();
        }

        #region Opgave 2
        private void Opgave2()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- WEEK 2 OPGAVE 2 ---\n");

            WriteLine("Voer de getallen in die je wilt gebruiken.");
            WriteLine("Zorg er voor dat de getallen gescheiden zijn met een comma");
            string input = ReadLine();
            string[] split = input.Split(',');

            int[] values = Array.ConvertAll(split, int.Parse);

            WriteLine($"Welke waarde wil je selecteren? (van 0 tot {values.Length - 1})");
            string inputIndex = ReadLine();

            if (int.TryParse(inputIndex, out int index))
            {
                if (index < 0 || index > values.Length)
                {
                    if (Homework.PromptRetry("Index out of range", Opgave2))
                    {
                        return;
                    }
                }
                else
                {
                    WriteLine();
                    WriteLine($"De waarde in {index} is {values[index]}");
                }
            }
        }
        #endregion

        #region Opgave 3
        private void Opgave3()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- WEEK 2 OPGAVE 3 ---\n");

            WriteLine("Voer de getallen in waarbij alleen de oneven getallen geprint worden.");
            WriteLine("Zorg er voor dat de getallen gescheiden zijn met een comma");
            string input = ReadLine();
            string[] split = input.Split(',');

            int[] values = Array.ConvertAll(split, int.Parse);

            WriteLine();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    WriteLine($"{values[i]} is een even getal");
                }
            }
        }
        #endregion

        #region Opgave 4
        private void Opgave4()
        {
            WriteLine("--- WEEK 2 OPGAVE 4 ---\n");

            int[] firstComponents = {
                1,
                5,
                8,
                9,
                2,
            };

            int[] secondComponents = {
                4,
                3,
                6,
                7,
                0,
            };

            int[] sums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sums[i] = firstComponents[i] + secondComponents[i];
                WriteLine($"{firstComponents[i]} + {secondComponents[i]} = {sums[i]}");
            }

            WriteLine();
        }
        #endregion

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
