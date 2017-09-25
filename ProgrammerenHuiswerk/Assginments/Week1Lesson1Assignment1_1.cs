using ProgrammerenHuiswerk.Framework;

namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment1_1 : BaseRunable, IWeekProvider, ILessonProvider, IMultipleAssignmentsProvider
    {
        public int Week { get { return 1; } }
        public int Lesson { get { return 1; } }

        public string[] AssignmentIds
        {
            get
            {
                return new[] { "1.1", "1.2" };
            }
        }

        private static string Naam = "Fiona";
        private static char Variable1 = 'C';
        private static int Number1 = 123;
        private static double Number2 = 1.5;
        private static bool Status = true;
        private static int Leeftijd = 35;

        public override void Execute()
        {
            Output.Add($"{Naam} Sariedine {Variable1}");
            Output.Add($"{Number1} {Number2}");
            Output.Add($"{Leeftijd} {Status}");
        }
    }
}
