using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson2Assignment1 : BaseRunable, IWeekProvider, ILessonProvider, IMultipleAssignmentsProvider
    {
        public int Week => 1;
        public int Lesson => 2;
        public string[] AssignmentIds => new[] { "2.0", "2.1", "2.2" };

        public override void Execute()
        {
            AssignmentHelper.RequestInput(this, "Hoe oud ben je?", out int age);
            AssignmentHelper.RequestInput(this, "Met hoeveel mensen ben je?", out int size);

            ConsoleKey ladiesNight = AssignmentHelper.RequestKey(
                "Is het vanavond Ladies night?",
                new[] { ConsoleKey.Y, ConsoleKey.N }
            );


            //Check if it's ladies night.
            if (ladiesNight == ConsoleKey.Y)
            {
                ConsoleKey married = AssignmentHelper.RequestKey(
                    "Ben je gehuwd?",
                    new[] { ConsoleKey.Y, ConsoleKey.N }
                );

                if (married == ConsoleKey.Y)
                {
                    Output.Add("Je moet ongehuwd zijn om mee te doen aan de ladies night.");
                    return;
                }

                if (married == ConsoleKey.N)
                {
                    if (age < 30)
                    {
                        Output.Add($"Je bent {age} jaar oud, je hebt toegang tot de club.");
                    }
                    else
                    {
                        Output.Add($"Je bent te oud. :(");
                        return;
                    }
                }
            }

            // Normal routine check.
            if (age < 16)
            {
                Output.Add("Je moet minimaal 16 jaar oud zijn.");
                return;
            }
            else
            {
                Output.Add($"Je bent {age} jaar oud, veel plezier!");
            }

            if (age >= 21)
            {
                Output.Add($"Omdat je 21 jaar of ouder bent, krijg je ook VIP toegang.");
            }

            int discount = 0;
            switch (size)
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
            if (discount == 0)
            {
                discountStr += "geen korting.";
            }
            else if (discount == 100)
            {
                discountStr += "gratis toegang.";
            }
            else
            {
                discountStr += + discount + "% korting.";
            }


            Output.Add($"Een groep met {size} mensen krijgt {discountStr}");
        }
    }
}
