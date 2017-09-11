using ProgrammerenHuiswek.Temperature;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    class Week1
    {
        static bool SkipRequiredInput = true;

        #region Les1 Opgave 1.1
        private static string Naam = "Fiona";
        private static char Variable1 = 'C';
        private static int Number1 = 123;
        private static double Number2 = 1.5;
        private static bool Status = true;
        private static int Leeftijd = 35;
        #endregion

        private static void Main(string[] args)
        {
            //int winst = 100;
            //int inzet = 0;
            //Random rnd = new Random();

            //while (true)
            //{
            //    WriteLine("Wat is je inzet?");
            //    winst = Convert.ToInt32(ReadLine());

            //    for (int i = 0; i < 3; i++)
            //    {
            //        int sum = 0;
            //        int roll1 = rnd.Next(1, 7);
            //        int roll2 = rnd.Next(1, 7);

            //        WriteLine($"Rolled {roll1}");
            //        WriteLine($"Rolled {roll2}");

            //        if (roll1 == 6 && roll2 == 6)
            //        {
            //            inzet += 50;
            //        }

            //        if (roll1 == roll2)
            //        {
            //            inzet += 10;
            //        }

            //        WriteLine("----------");
            //    }

            //    int w = winst * inzet;
            //    WriteLine($"Je hebt {w} gewonnen, wil je nog een keer spelen (Y/N)");
            //    ConsoleKeyInfo key = ReadKey();

            //    if (key.Key == ConsoleKey.N)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        winst = 0;
            //        inzet = 0;
            //    }

            //}

            //string[] naam = {
            //    "Eerste",
            //    "Tweede",
            //    "Derde"
            //};

            //naam[0]; // Eerste
            //naam[1]; // Tweede

            ////Les 1
            Les1Opgave12();
            Les1Opgave13();
            Les1Opgave21();
            Les1Opgave22("bla", 3);
            Les1Opgave3();
            Les1Opgave4();
            Les1Opgave5();
            Les1Opgave6();

            Les2Opgave1();
            Les2Opgave2();
            Les2Opgave3();
            Les3Opgave1();

            ReadLine();
        }

        #region Les 1 Opgave 1.2
        private static void Les1Opgave12()
        {
            WriteLine("--- LES 1 OPGAVE 1.2 ---\n");

            WriteLine($"{Naam} Sariedine {Variable1}");
            WriteLine($"{Number1} {Number2}");
            WriteLine($"{Leeftijd} {Status}");

            WriteLine();
        }
        #endregion

        #region Les 1 Opgave 1.3
        private static void Les1Opgave13()
        {
            WriteLine("--- LES 1 OPGAVE 1.3 EN 1.4 ---\n");

            double rest = Number1 % Number2;

            WriteLine($"Rest is {rest}");
            WriteLine();
        }
        #endregion

        #region Les 1 Opgave 2.1
        private static void Les1Opgave21()
        {
            WriteLine("--- LES 1 OPGAVE 2.1 ---\n");

            string woordA = "Hello";
            string woordB = "World";
            string zin = "";
            zin = woordA + " " + woordB;

            WriteLine(zin);
            WriteLine();
        }
        #endregion

        #region Les 1 Opgave 2.2
        private static void Les1Opgave22(string word, int n)
        {
            WriteLine("--- LES 1 OPGAVE 2.2 ---\n");

            //Append word n times.
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                builder.Append(word);
            }

            WriteLine(builder.ToString());
            WriteLine();
        }
        #endregion

        #region Les 1 Opgave 3
        /*
            Q: Welke datatypes gebruik je? Motiveer je keuze
            A:
                - doubles, omdat temperaturen vaak decimale waarde kunnen hebben.
                - string, om de gebruikers input te verkrijgen en in op te slaan.
                - char, voor de aanduiding van de (temperatuur) eenheid.
         */
        private static void Les1Opgave3()
        {
            if (SkipRequiredInput) return;

            WriteLine("--- LES 1 OPGAVE 3 ---\n");

            //Prompt the user.
            WriteLine("Available units: F (Farhenheit), C (Celsius), K (Kelvin)");
            WriteLine("Enter a value suffixed with the letter of the unit (i.e. 25.5F or 14.6C):");
            string userInputSourceString = ReadLine();

            //Parse the user input into a tuple of the unit and value.
            Tuple<TemperatureUnit, double> inputSource = TemperatureParser.Parse(userInputSourceString.ToLower());

            if (inputSource.Item1 == TemperatureUnit.Unknown)
            {
                if (!PromptRetry("The letter you supplied is not a valid unit", Les1Opgave3))
                {
                    return;
                }
            }

            //Prompt user to select which unit to convert to.
            WriteLine("To which unit would you like to convert it to? (Type the letter)");
            string userInputUnitType = ReadLine();

            //Check if the given charater is a valid unit.
            TemperatureUnit unitToConvertTo = TemperatureUnit.Unknown;
            char unitChar = '0';
            if (char.TryParse(userInputUnitType, out unitChar))
            {
                unitToConvertTo = (TemperatureUnit)unitChar;

                if (unitToConvertTo == TemperatureUnit.Unknown)
                {
                    if (!PromptRetry("The letter supplied is not a valid unit", Les1Opgave3))
                    {
                        return;
                    }
                }
            }
            else
            {
                if (!PromptRetry("The entered value is not an letter.", Les1Opgave3))
                {
                    return;
                }
            }

            //Check if we are not trying to convert to the same type:
            if (unitToConvertTo == inputSource.Item1)
            {
                if (!PromptRetry("Redundant conversion, converting to the same unit.", Les1Opgave3))
                {
                    return;
                }
            }

            bool calculateWindChill = false;
            double windSpeed = 0.0;

            WriteLine("Do you also want to show the temperature with windchil? (Y/N)");
            ConsoleKeyInfo key = ReadKey();

            //Prompt the user to ask if they also want to take windchill into account.
            if (key.Key == ConsoleKey.Y)
            {
                WriteLine("\nNOTE: The windchill formula typically only works with temperatures between +10 and -49 celsius.");
                WriteLine("How fast is the wind blowing in km/hour? (Higher = colder, Lower = warmer)");
                string input = ReadLine();

                if (!double.TryParse(input, out windSpeed))
                {
                    if (!PromptRetry("Invalid input, please input a decimal number (i.e. `10.0`)", Les1Opgave3))
                    {
                        return;
                    }
                }
                else
                {
                    calculateWindChill = true;
                    WriteLine();
                }

            }

            //Lookup conversion, print result
            double result = TemperatureConverter.Convert(inputSource.Item2, inputSource.Item1, unitToConvertTo);
            double resultRounded = Math.Round(result, 2);

            StringBuilder builder = new StringBuilder();
            builder.Append($"The original temperature was {inputSource.Item2} {inputSource.Item1} \n");
            builder.Append($"Converted it is {result} {unitToConvertTo}\n");

            //Append the results of the wind chill calculations.
            if (calculateWindChill)
            {
                double resultWindChill = TemperatureConverter.ConvertInclWindChill(inputSource.Item2, windSpeed, inputSource.Item1, unitToConvertTo);
                double resultWindChillRounded = Math.Round(resultWindChill, 2);

                builder.Append($"Taking windchill into account, the temperature is now {resultWindChillRounded} {unitToConvertTo} \n");
                builder.Append($"If the wind is blowing at {windSpeed} km/h");
            }

            //Write out the entire result.
            WriteLine(builder.ToString());

            WriteLine();
            WriteLine("Oant moan!");
            WriteLine();
        }
        #endregion

        #region Les 1 Opgave 4
        /*
         Q: Wat zijn deverschillen tussen float en	double type (zoek het	op	internet) en geef een	
         duidelijk voorbeeld waarin	je de verschillen tussen de typen kan zien.	
         
         A: De percisie is het verschil tussen double and float.
            Float is bekend als "single percision", float gebruiken 32 bits.
            Double is bekend als "double percision", dubbel de percisie en dus 64 bits.
            Ook hebben we decimal, die gebruikt 128 bits.
            Om deze te kunnen via de console de waarden weergeven, je zal zien dat float minste decimalen heeft en decimal de meeste.      
        */

        private static void Les1Opgave4()
        {
            WriteLine("--- LES 1 OPGAVE 4 ---\n");

            //32 bits (7 decimals)
            float a = 1f / 3;

            //64 bits (16 decimals)
            double b = 1d / 3;

            //128 bits (32 decimals);
            decimal c = 1m / 3;

            WriteLine($"Float value: {a}");
            WriteLine($"Double value: {b}");
            WriteLine($"Decimal value: {c}");

            WriteLine();
        }
        #endregion

        #region Les 1 Opgave 5
        private static void Les1Opgave5()
        {
            if (SkipRequiredInput) return;

            WriteLine("--- LES 1 OPGAVE 5 ---\n");

            const double USD = 1.2231;

            WriteLine("How many euros do you want to convert to USD");
            string userInput = ReadLine();

            double euros = 0.0;
            if (double.TryParse(userInput, out euros))
            {
                double usdConverted = euros * USD;
                WriteLine($"{euros} EUR is gelijk aan {usdConverted} USD");
            }
        }
        #endregion

        #region Les 1 Opgave 6
        private static void Les1Opgave6()
        {
            if (SkipRequiredInput) return;

            WriteLine("--- LES 1 OPGAVE 6 ---\n");

            WriteLine("What is your first name?");
            string name = ReadLine();

            WriteLine("What is your last name?");
            string lastName = ReadLine();

            WriteLine("What is the name of the street you live in?");
            string street = ReadLine();

            WriteLine("What is the house number?");
            string houseNumber = ReadLine();

            WriteLine("What is your postal code?");
            string postalCode = ReadLine();

            WriteLine("Which city do you live in?");
            string city = ReadLine();

            WriteLine("Output:");
            WriteLine();

            WriteLine("===================================================");
            WriteLine("| {0,-22} | {1,-22} |", name, lastName);
            WriteLine("| {0,-22} | {1,-22} |", street, houseNumber);
            WriteLine("| {0,-22} | {1,-22} |", postalCode, city);
            WriteLine("===================================================");
        }
        #endregion

        #region Les 2 Opgave 1
        private static void Les2Opgave1()
        {
            if (SkipRequiredInput) return;

            WriteLine("--- LES 2 OPGAVE 1 ---\n");

            //Ask for the variables.
            WriteLine("How old are you?");
            string inputAge = ReadLine();

            WriteLine("How many people are you with?");
            string inputSize = ReadLine();

            WriteLine("Is today ladies night? (Y/N)");
            ConsoleKeyInfo infoLadiesNight = ReadKey();

            //Convert age and group size to int.
            int age = 0;
            int size = 1;

            if (!int.TryParse(inputAge, out age) || !int.TryParse(inputSize, out size))
            {
                if (!PromptRetry("Entered values are not a number...", Les2Opgave1))
                {
                    return;
                }
            }

            //Check if it's ladies night.
            if (infoLadiesNight.Key == ConsoleKey.Y)
            {
                WriteLine("Are you married? (Y/N)");
                ConsoleKeyInfo infoMarried = ReadKey();

                if (infoMarried.Key == ConsoleKey.Y)
                {
                    WriteLine("You must be unmarried to enter the club at ladies night!");
                    return;
                }
                else if (infoMarried.Key == ConsoleKey.N)
                {
                    if (age < 30)
                    {
                        WriteLine($"You are {age} old and therefor have acess to the club");
                    }
                    else
                    {
                        WriteLine($"You are too old for the ladies night!");
                    }
                }

                return;
            }

            // Normal routine check.
            if (age < 16)
            {
                WriteLine("You must be atleast 16 years old to enter the club");
                return;
            }
            else
            {
                WriteLine($"You are {age} years old, have fun.");
            }

            if (age >= 21)
            {
                WriteLine($"Since you are 21 years or older, you get VIP access!");
            }

            int discount = 0;
            switch(size)
            {
                case 0:
                case 1:
                case 2:
                    discount = 0;
                    break;

                case 3:
                    discount = 10;
                    break;

                case 4:
                    discount = 20;
                    break;

                case 5:
                    discount = 50;
                    break;

                default:
                    discount = 100;
                    break;
            }

            string discountStr = "";
            if(discount == 0)
            {
                discountStr += "no discount.";
            }
            else if(discount == 100)
            {
                discountStr += "free access.";
            }
            else
            {
                discountStr += discount + "% discount.";
            }


            WriteLine($"A group with {size} people gets {discountStr}");
        }
        #endregion

        #region Les 2 Opgave 2
        private static void Les2Opgave2()
        {
            if (SkipRequiredInput) return;

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
            if (SkipRequiredInput) return;

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
            if (SkipRequiredInput) return;

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


        #region Helper stuff
        private static bool PromptRetry(string message, Action retryAction)
        {
            WriteLine(message);
            WriteLine("The program cannot proceed, do you want to retry? (Y/N)");
            ConsoleKeyInfo key = ReadKey();

            if (key.Key == ConsoleKey.Y)
            {
                WriteLine();
                retryAction();
                return true;
            }

            return false;
        }
        #endregion
    }
}
