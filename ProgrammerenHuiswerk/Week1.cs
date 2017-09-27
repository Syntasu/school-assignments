﻿using System;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week1
    {


        public Week1()
        {
            Les3Opgave5();
        }

    

        #region Les 3 Opgave 5
        private static void Les3Opgave5()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- LES 3 OPGAVE 5 ---\n");
            int bet = 0;
            int multiplier = 0;
            int sixCounter = 0;

            Random rnd = new Random();

            while (true)
            {
                WriteLine("Hoeveel euro wil je inzetten?");
                string inputWinst = ReadLine();

                if (!int.TryParse(inputWinst, out bet))
                {
                    if (!Homework.PromptRetry("The given value is not a number", Les3Opgave5))
                    {
                        break;
                    }
                }
                else
                {
                    if(bet > 100 || bet < 5)
                    {
                        if (!Homework.PromptRetry("The bet must atleast be 5 EUR and maximum 100 EUR.", Les3Opgave5))
                        {
                            break;
                        }
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    WriteLine("Druk een toets om the dobbelen...");
                    ReadKey();

                    int roll1 = rnd.Next(1, 7);
                    int roll2 = rnd.Next(1, 7);

                    WriteLine();
                    WriteLine($"Dobbelsteen 1 gooit: {roll1}");
                    WriteLine($"Dobbelsteen 2 gooit: {roll2}");
                    WriteLine();

                    if (roll1 == 6 && roll2 == 6)
                    {
                        multiplier += 50;
                        WriteLine("Je hebt dubbel zessen, je inzet is x50!");
                    }

                    if (roll1 == roll2)
                    {
                        multiplier += 10;
                        WriteLine("Je hebt de zelfde getallen, je inzet is x10!");
                    }

                    if (roll1 == 6) sixCounter++;
                    if (roll2 == 6) sixCounter++;
                }

                WriteLine();

                if(sixCounter >= 2)
                {
                    WriteLine("Je hebt bij de 3 worpen 2 of meer zessen gegooid. Je inzet is x2!");
                    multiplier += 2;
                }

                int w = bet * multiplier;
                if(w == 0)
                {
                    WriteLine("Helaas je hebt niks gewonnen!");
                }
                else
                {
                    WriteLine($"Je hebt {w} euro gewonnen!");
                }

                WriteLine();
                WriteLine("Wil je nog een keer spelen (Y/N)");
                WriteLine();
                ConsoleKeyInfo key = ReadKey();

                if (key.Key == ConsoleKey.N)
                {
                    break;
                }
                else
                {
                    bet = 0;
                    multiplier = 0;
                }

            }
        }
#endregion
    }
}
