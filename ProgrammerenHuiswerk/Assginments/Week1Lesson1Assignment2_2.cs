using ProgrammerenHuiswerk.Framework;

namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment2_2 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string AssignmentId => "2.2";

        public override void Execute()
        {
            int n = 3;
            string word = "bla";

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += word;
            }

            Output.Add($"Het woord {word} {n} keer herhaald is {result}");
        }
    }
}
