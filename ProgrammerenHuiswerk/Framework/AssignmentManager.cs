using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammerenHuiswerk.Framework
{
    public class AssignmentManager
    {
        private static IList<BaseRunable> _runnables = new List<BaseRunable>();

        public static void Register(BaseRunable runable)
        {
            if(!_runnables.Contains(runable))
            {
                _runnables.Add(runable);
            }
        }

        public static IDictionary<BaseRunable,string> GetOptions()
        {
            IDictionary<BaseRunable, string> options = new Dictionary<BaseRunable, string>();
            StringBuilder stringBuilder = new StringBuilder();

            // Loop over all the runables.
            foreach (BaseRunable runable in _runnables)
            {
                Type runableType = runable.GetType();

                //Check if the class implements a week provider interface.
                if(typeof(IWeekProvider).IsAssignableFrom(runableType))
                {
                    IWeekProvider weekProvider = (IWeekProvider)runable;
                    stringBuilder.Append($"Week {weekProvider.Week}, ");
                }

                //Check if the class provides a lesson provider.
                if (typeof(ILessonProvider).IsAssignableFrom(runableType))
                {
                    ILessonProvider lessonProvider = (ILessonProvider)runable;
                    stringBuilder.Append($"Lesson {lessonProvider.Lesson}, ");
                }

                // Check if the class implements a single or multiple assignment interface.
                if (typeof(ISingleAssignmentProvider).IsAssignableFrom(runableType))
                {
                    ISingleAssignmentProvider singleAssignment = (ISingleAssignmentProvider)runable;
                    stringBuilder.Append($"Assignment; {singleAssignment.AssignmentId}.");
                }
                else if(typeof(IMultipleAssignmentsProvider).IsAssignableFrom(runableType))
                {
                    IMultipleAssignmentsProvider multiAssignment = (IMultipleAssignmentsProvider)runable;
                    stringBuilder.Append($"Assignments; {String.Join(" and ", multiAssignment.AssignmentIds)}.");
                }

                //Store the option.
                options.Add(runable, stringBuilder.ToString());
                stringBuilder.Clear();
            }

            return options;
        }

        public static void StartUserSelection()
        {
            IDictionary<BaseRunable, string> options = GetOptions();
            int currentIndex = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ===============================================================================================");
                Console.WriteLine(" === Please select an assignment, using the arrow keys and enter key to select an assignment === ");
                Console.WriteLine(" ===============================================================================================");

                Console.WriteLine();

                int count = 0;
                foreach (KeyValuePair<BaseRunable, string> kvp in options)
                {
                    string optionString = string.Empty;

                    if (currentIndex == count)
                    {
                        optionString += "[ XXX ] - ";
                    }
                    else
                    {
                        optionString += "[ --- ] - ";
                    }

                    optionString += kvp.Value;
                    Console.WriteLine(optionString);
                    count++;
                }

                ConsoleKeyInfo info = Console.ReadKey();

                //Handle selecting up, check if in bounds.
                if (info.Key == ConsoleKey.UpArrow && currentIndex > 0)
                {
                    currentIndex--;
                    continue;
                }

                //Handle selecting down, checking the bounds.
                if (info.Key == ConsoleKey.DownArrow
                    && currentIndex < options.Count - 1)
                {
                    currentIndex++;
                    continue;
                }

                //If the user pressed enter, get which runable was selected and execute it.
                if (info.Key == ConsoleKey.Enter)
                {
                    int c = 0;
                    foreach (KeyValuePair<BaseRunable, string> kvp in options)
                    {
                        if(currentIndex == c)
                        {
                            ExecuteRunable(kvp.Value, kvp.Key);
                            break;
                        }

                        c++;
                    }
                }
            }
        }

        private static void ExecuteRunable(string name, BaseRunable runable)
        {
            //Clear the console and state which assignment is running.
            Console.Clear();
            Console.WriteLine($"Running [{name}], Output:\n");

            //Execute, print result and flush the runable.
            runable.Execute();
            Console.WriteLine(runable.OutputString);
            runable.Flush();

            //State that we are done, wait for the user to press a key.
            Console.WriteLine($"Done running [{name}] press a key to continue...");
            Console.ReadKey();
        }
    }
}
