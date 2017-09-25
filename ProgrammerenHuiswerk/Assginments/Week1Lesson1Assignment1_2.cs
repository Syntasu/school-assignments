using ProgrammerenHuiswerk.Framework;
namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment1_2 : BaseRunable, IWeekProvider, ILessonProvider, IMultipleAssignmentsProvider
    {
        public int Week { get { return 1; } }
        public int Lesson { get { return 1; } }

        public string[] AssignmentIds
        {
            get
            {
                return new[] { "1.3", "1.4" };
            }
        }

        private static int Number1 = 123;
        private static double Number2 = 1.5;

        public override void Execute()
        {
            double rest = Number1 % Number2;
            Output.Add($"Rest is {rest}");
        }
    }
}
