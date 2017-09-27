using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson3Assignment5 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 3;
        public string AssignmentId => "5";

        public override void Execute()
        {
            int multiplier = 0;
            int sixCounter = 0;
            Random rnd = new Random();

            while (true)
            {
                AssignmentHelper.RequestInput(
                    this,
                    "Hoeveel euro wil je inzetten?",
                    out int bet
                );

                if(bet > 100)
                {
                    Error = "Inzet is te hoog, maximaal 100 EUR!";
                    return;
                }

                if(bet < 5)
                {
                    Error = "Inzet is te laag, minimaal 5 EUR!";
                    return;
                }

                for (int i = 0; i < 3; i++)
                {
                    Output.Add("Druk een toets om the dobbelen...");
                    ShowOutput();

                    Console.ReadKey();

                    int roll1 = rnd.Next(1, 7);
                    int roll2 = rnd.Next(1, 7);

                    Output.Add("");
                    Output.Add($"Je gooit dobbelsteen 1 en gooit {roll1}");
                    Output.Add($"Je gooit dobbelsteen 2 en gooit {roll2}");
                    Output.Add("");

                    if (roll1 == 6 && roll2 == 6)
                    {
                        multiplier += 50;
                        Output.Add("Je hebt dubbel zessen, je inzet is x50!");
                    }

                    if (roll1 == roll2)
                    {
                        multiplier += 10;
                        Output.Add("Je hebt twee de zelfde getallen, je inzet is x10!");
                    }

                    if (roll1 == 6) sixCounter++;
                    if (roll2 == 6) sixCounter++;
                }

                Output.Add("");

                if (sixCounter >= 2)
                {
                    Output.Add("Je hebt bij de 3 worpen 2 of meer zessen gegooid. Je inzet is x2!");
                    multiplier += 2;
                }

                int w = bet * multiplier;
                if (w == 0)
                {
                    Output.Add("Helaas je hebt niks gewonnen!");
                }
                else
                {
                    Output.Add($"Je hebt {w} euro gewonnen!");
                }

                ShowOutput();

                ConsoleKey key = AssignmentHelper.RequestKey(
                    "Wil je nog een keer spelen?", 
                    new[] { ConsoleKey.Y, ConsoleKey.N }
                );


                if (key == ConsoleKey.N)
                {
                    break;
                }
                else if (key == ConsoleKey.Y)
                {
                    bet = 0;
                    multiplier = 0;
                }
                else
                {
                    Error = "Onbekende toets...";
                    return;
                }
            }
        }
    }
}
