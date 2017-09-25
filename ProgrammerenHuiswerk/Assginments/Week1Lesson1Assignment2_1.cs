using ProgrammerenHuiswerk.Framework;
namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment2_1 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week { get { return 1; } }
        public int Lesson { get { return 2; } }

        public string AssignmentId
        {
            get
            {
                return "2.1";
            }
        }

        private static int Number1 = 123;
        private static double Number2 = 1.5;

        public override void Execute()
        {
            string woordA = "Hello";
            string woordB = "World";
            string zin = "";
            zin = woordA + " " + woordB;

            Output.Add($"Result is `{zin}`");
        }
    }
}
