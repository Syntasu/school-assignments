using ProgrammerenHuiswerk.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson3Assignment3 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 3;
        public string AssignmentId => "3";

        public override void Execute()
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i < 11; i++)
            {
                int t = a;
                a = b;
                b = t + b;

                Output.Add($"{i} in de reeks van Fibonacci van is {a}");
            }
        }
    }
}
