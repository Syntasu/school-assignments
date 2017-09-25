using ProgrammerenHuiswerk.Framework;
namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment1_2 : BaseRunable, IWeekProvider, ILessonProvider, IMultipleAssignmentsProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string[] AssignmentIds => new[] { "1.3", "1.4" };


        private static int Number1 = 123;
        private static double Number2 = 1.5;

        public override void Execute()
        {
            double rest = Number1 % Number2;
            Output.Add($"De rest waarde van {Number1} gedeeld door {Number2} is {rest}");
        }
    }
}
