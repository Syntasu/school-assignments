using System;

namespace ProgrammerenHuiswerk.Framework
{
    public static class AssignmentHelper
    {
        public static bool RequestInput<T>(BaseRunable runable, string message, out T result)
        {
            Console.WriteLine(runable.OutputString);
            runable.Flush(false);

            Console.WriteLine(message);
            object input = Console.ReadLine();

            try
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch (Exception)
            {
                result = default(T);
                runable.Error = $"Kan {message} niet converteren naar {typeof(T)}";
                return false;
            }
        }

        public static ConsoleKey RequestKey(string message, ConsoleKey[] keys)
        {
            Console.WriteLine("");
            string keyString = string.Join(",", keys);
            Console.WriteLine(message + $" ({keyString})");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("");

            foreach(ConsoleKey key in keys)
            {
                if(keyInfo.Key == key)
                {
                    return key;
                }
            }

            return 0; 

        }

    }
}
