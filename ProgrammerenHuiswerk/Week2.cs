using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week2
    {
        public Week2()
        {
            Opgave1();
        }

        private void Opgave1()
        {
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
    }
}
