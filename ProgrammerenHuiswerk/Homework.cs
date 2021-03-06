﻿using ProgrammerenHuiswerk.Assignments;
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
            AssignmentManager.Register(new Week1Lesson1Assignment2_2());
            AssignmentManager.Register(new Week1Lesson1Assignment3a());
            AssignmentManager.Register(new Week1Lesson1Assignment3b());
            AssignmentManager.Register(new Week1Lesson1Assignment4());
            AssignmentManager.Register(new Week1Lesson1Assignment5());
            AssignmentManager.Register(new Week1Lesson1Assignment6());
            AssignmentManager.Register(new Week1Lesson2Assignment1());
            AssignmentManager.Register(new Week1Lesson2Assignment2());
            AssignmentManager.Register(new Week1Lesson2Assignment3());
            AssignmentManager.Register(new Week1Lesson3Assignment1());
            AssignmentManager.Register(new Week1Lesson3Assignment2());
            AssignmentManager.Register(new Week1Lesson3Assignment3());
            AssignmentManager.Register(new Week1Lesson3Assignment4());
            AssignmentManager.Register(new Week1Lesson3Assignment5());

            AssignmentManager.Register(new Week2Assignment1());
            AssignmentManager.Register(new Week2Assignment2());
            AssignmentManager.Register(new Week2Assignment3());
            AssignmentManager.Register(new Week2Assignment4());
            AssignmentManager.Register(new Week2Assignment5());
            AssignmentManager.Register(new Week2Assignment6());

            AssignmentManager.Register(new Week4Assignment1a());
            AssignmentManager.Register(new Week4Assignment1b());
            AssignmentManager.Register(new Week4Assignment1c());
            AssignmentManager.Register(new Week4Assignment2());





            AssignmentManager.StartUserSelection();
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
