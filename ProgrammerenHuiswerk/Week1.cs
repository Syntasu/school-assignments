﻿using ProgrammerenHuiswek.Temperature;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week1
    {


        public Week1()
        {
            Les2Opgave2();
            Les2Opgave3();

            Les3Opgave1();
            Les3Opgave2();
            Les3Opgave3();
            Les3Opgave4();
            Les3Opgave5();
        }


        #region Les 2 Opgave 2
        private static void Les2Opgave2()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- LES 2 OPGAVE 2 ---\n");

            IDictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "nl", "Tot ziens!"},
                { "fr", "Au revoir!"},
                { "frl", "Oant sjens!"},
                { "en", "Bye!"}
            };

            WriteLine("In which language would you like me to print the word `bye`?");
            WriteLine("The options are: NL(duth), FR(French), (FRL)Frisian, (EN)english");
            WriteLine("Write the 2 or 3 language code to print:");
            string language = ReadLine();

            string result = "";
            if(dictionary.TryGetValue(language.ToLower(), out result))
            {
                WriteLine($"Bye in {language.ToUpper()} is {result}");
            }
            else
            {
                WriteLine("Unknown language :(");
            }
        }
        #endregion

        #region Les 2 Opgave 3
        private static void Les2Opgave3()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- LES 2 OPGAVE 3 ---\n");

            double length = 1.0;
            double wristCircumference = 1.0;

            WriteLine("Are you a male or female (M/F)");
            ConsoleKeyInfo key = ReadKey();

            WriteLine("How tall are you? (in cm)");
            string inputLength = ReadLine(); 

            if(!double.TryParse(inputLength, out length))
            {
                WriteLine("You entered a non nummeric value");
                return;
            }

            if(key.Key == ConsoleKey.M)
            {
                int ideal = Convert.ToInt32(length - 100.0);
                WriteLine($"You ideal weight is {ideal} kg");
            }
            else if(key.Key == ConsoleKey.F)
            {
                WriteLine("What is your wrist circumference? (in cm)");
                wristCircumference = Convert.ToDouble(ReadLine());

                int ideal = Convert.ToInt32((length + 4.0 * wristCircumference - 100) / 2);
                WriteLine($"You ideal weight is {ideal} kg");
            }
            else
            {
                WriteLine("Sorry, we don't support apache helicopters.");
            }
        }
        #endregion

        #region Les 3 Opgave 1
        private static void Les3Opgave1()
        {
            if (Homework.SkipRequiredInput) return;

            WriteLine("--- LES 3 OPGAVE 1 ---\n");

            WriteLine("Voer getallen waarvan je de grootste getal wil selecteren.");
            WriteLine("Zorg er voor dat de getallen gescheiden zijn met een comma");
            string input = ReadLine();
            string[] split = input.Split(',');

            int[] values = Array.ConvertAll(split, int.Parse);

            int highestValue = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > highestValue)
                {
                    highestValue = values[i];
                }
            }

            WriteLine($"The highest value is {highestValue}");
        }
        #endregion

        #region Les 3 Opgave 2
        private static void Les3Opgave2()
        {
            WriteLine("--- LES 3 OPGAVE 2 ---\n");

            for (int i = 1; i <= 10; i++)
            {
                int result = (int)Math.Pow(2, i);

                WriteLine($"2 to the power of {i} is {result}");
            }

            WriteLine();
        }
        #endregion

        #region Les 3 Opgave 3
        private static void Les3Opgave3()
        {
            WriteLine("--- LES 3 OPGAVE 3 ---\n");

            int a = 0;
            int b = 1;
            for (int i = 0; i <= 10; i++)
            {
                //NOTE: Don't compute fibonacci for n == 0, since it's constrained to n > 1
                if (i != 0)
                { 
                    int t = a;
                    a = b;
                    b = t + b;
                }

                WriteLine($"Fibonacci({i}) = {a}");
            }

            WriteLine();
        }
        #endregion

        #region Les 3 Opgave 4
        private static void Les3Opgave4()
        {
            if (Homework.SkipRequiredInput) return;
            WriteLine("--- LES 3 OPGAVE 4 ---\n");

            bool exit = false;
            float totalDriven = 0.0f;
            float fuelUsed = 0.0f;

            while(true)
            {
                WriteLine("Hoeveel kilometer heeft u gereden sinds laatste tankbeurt?");
                string inputKm = ReadLine();

                float km = 0;
                if(float.TryParse(inputKm, out km))
                {
                    totalDriven += km;
                }
                else
                {
                    WriteLine("De gegeven aantal kilometers is geen getal!");
                    return;
                }

                WriteLine("Hoeveel liter heeft u getankt?");
                string inputFuel = ReadLine();

                float fuel = 0;
                if (float.TryParse(inputFuel, out fuel))
                {
                    if(fuel == 0)
                    {
                        break;
                    }

                    fuelUsed += fuel;
                }
                else
                {
                    WriteLine("De gegeven aantal liters is geen getal!");
                    return;
                }
            }

            WriteLine($"Je hebt {totalDriven} km gereden en {fuelUsed} liter brandstof verbruikt.");

            float fuelConsumption = (float)Math.Round(100 / (totalDriven / fuelUsed), 2);
            WriteLine($"Brandstof verbruik is {fuelConsumption} liter per 100 km.");
        }
        #endregion

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
