using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson3Assignment4 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 3;
        public string AssignmentId => "4";

        public override void Execute()
        {
            bool exit = false;
            float totalDriven = 0.0f;
            float fuelUsed = 0.0f;

            while (true)
            {
                AssignmentHelper.RequestInput(
                    this,
                    "Hoeveel kilometer heeft u gereden sinds laatste tankbeurt?",
                    out float km
                );

                AssignmentHelper.RequestInput(
                    this,
                    "Hoeveel liter heeft u getankt?",
                    out float fuel
                );

                totalDriven += km;
                fuelUsed += fuel;

                if (fuel == 0) break;
            }

            Output.Add("");
            Output.Add($"Je hebt {totalDriven} km gereden en {fuelUsed} liter brandstof verbruikt.");

            float fuelConsumption = (float)Math.Round(100 / (totalDriven / fuelUsed), 2);
            Output.Add($"Brandstof verbruik is {fuelConsumption} liter per 100 km.");
        }
    }
}
