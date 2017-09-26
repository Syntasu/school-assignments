using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson3Assignment2 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 3;
        public string AssignmentId => "2";

        public override void Execute()
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = (int)Math.Pow(2, i);

                Output.Add($"{i} tot de macht twee is {result}");
            }
        }
    }
}
