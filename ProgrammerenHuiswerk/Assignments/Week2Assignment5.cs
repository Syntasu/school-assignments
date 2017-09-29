using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week2Assignment5 : BaseRunable, IWeekProvider, ISingleAssignmentProvider
    {
        public int Week => 2;
        public string AssignmentId => "5";

        public override void Execute()
        {
            AssignmentHelper.RequestInput(
                this,
                "Hoeveel leerlingen wil je toevoegen?",
                out int students
            );

            string[] studentNames = new string[students];

            for (int i = 0; i < students; i++)
            {
                AssignmentHelper.RequestInput(
                    this,
                    "Wat is de naam van de leerling?",
                    out string studentName
                );

                studentNames[i] = studentName;
            }

            string names = String.Join(", ", studentNames);
            Output.Add($"In totaal hebben we {students} leerlingen met de namen: {names}");
        }
    }
}
