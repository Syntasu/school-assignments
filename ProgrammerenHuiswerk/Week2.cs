using System;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week2
    {
        public Week2()
        {
            Opgave1();
            Opgave2();
            Opgave3();
        }

        private void Opgave1()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- WEEK 2 OPGAVE 1 ---\n");
            int[] values = new int[3];

            for (int i = 0; i < 3; i++)
            {
                WriteLine("Voer een getal in");
                string inputNumber = ReadLine();

                if (int.TryParse(inputNumber, out int number))
                {
                    values[i] = number;
                }
                else
                {
                    if (!Homework.PromptRetry("Entered a non-nummeric value", Opgave1))
                    {
                        return;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            WriteLine($"De som van de waarden is {sum}");
            WriteLine();
        }

        private void Opgave2()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- WEEK 2 OPGAVE 2 ---\n");

            WriteLine("Voer de getallen in die je wilt gebruiken.");
            WriteLine("Zorg er voor dat de getallen gescheiden zijn met een comma");
            string input = ReadLine();
            string[] split = input.Split(',');

            int[] values = Array.ConvertAll(split, int.Parse);

            WriteLine($"Welke waarde wil je selectenten? (van 0 tot {values.Length - 1})");
            string inputIndex = ReadLine();

            if(int.TryParse(inputIndex, out int index))
            {
                if(index < 0 || index > values.Length)
                {
                    if(Homework.PromptRetry("Index out of range", Opgave2))
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

        private void Opgave3()
        {
            WriteLine("--- WEEK 2 OPGAVE 3 ---\n");

            WriteLine("Voer de getallen in waarbij alleen de oneven getallen geprint worden.");
            WriteLine("Zorg er voor dat de getallen gescheiden zijn met een comma");
            string input = ReadLine();
            string[] split = input.Split(',');

            int[] values = Array.ConvertAll(split, int.Parse);

            WriteLine();

            for (int i = 0; i < values.Length; i++)
            {
                if(values[i] % 2 == 0)
                {
                    WriteLine($"{values[i]} is een even getal");
                }
            }
        }
    }
}
