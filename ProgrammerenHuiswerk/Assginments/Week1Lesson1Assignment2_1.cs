using ProgrammerenHuiswerk.Framework;
namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment2_1 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 2;
        public string AssignmentId => "2.1";

        private static int Number1 = 123;
        private static double Number2 = 1.5;

        public override void Execute()
        {
            string woordA = "Hello";
            string woordB = "World";
            string zin = "";
            zin = woordA + " " + woordB;

            Output.Add($"Resultaat is `{zin}`");
        }
    }
}
