using System;

namespace ProgrammerenLes3_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print 5 times hello world");
            RepeatHelloWorld(5);
            Console.WriteLine();

            Console.WriteLine("Print 10 times hello world");
            RepeatHelloWorld(10);
            Console.WriteLine();

            Console.WriteLine("");
            HelloWorldModulo(2);
            Console.WriteLine();

            Console.ReadLine();

        }

        private static void RepeatHelloWorld(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello World");
            }
        }

        private static void HelloWorldModulo(int count)
        {
            string a = "hello";
            string b = "world";
            int i = 0;

            do
            {
                Console.Write(i % 2 == 0 ? a : b);
                Console.Write(" ");
                i++;

            } while (i < (count * 2));


        }
    }
}
