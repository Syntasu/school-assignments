using ProgrammerenHuiswerk.Assginments;
using ProgrammerenHuiswerk.Framework;
using System;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Homework
    {
        public static bool SkipRequiredInput = true;

        private static void Main(string[] args)
        {
            AssignmentManager.Register(new Week1Lesson1Assignment1_1());
            AssignmentManager.Register(new Week1Lesson1Assignment1_2());
            AssignmentManager.Register(new Week1Lesson1Assignment2_1());

            AssignmentManager.StartUserSelection();

            //WriteLine("====== WEEK 1 ====== \n");
            //Week1 w1 = new Week1();

            //WriteLine("====== WEEK 2 ====== \n");
            //Week2 w2 = new Week2();

            //WriteLine("====== WEEK 4 ====== \n");
            //Week4 w4 = new Week4();

            ReadLine();
        }

        #region Helper stuff
        public static bool PromptRetry(string message, Action retryAction)
        {
            WriteLine(message);
            WriteLine("The program cannot proceed, do you want to retry? (Y/N)");
            ConsoleKeyInfo key = ReadKey();

            if (key.Key == ConsoleKey.Y)
            {
                WriteLine();
                retryAction();
                return true;
            }

            return false;
        }
        #endregion
    }
}
