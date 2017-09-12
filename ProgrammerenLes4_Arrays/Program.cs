using System;

namespace ProgrammerenLes4_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayIntitialization();
            ArrayIteration();

            Console.ReadLine();
        }

        private static void ArrayIntitialization()
        {
            //Initialize the array with values.
            string[] fruits =
            {
                "Apple",
                "Banana",
                "Strawberry",
                "Kiwi"
            };

            //Assign array via indexes.
            string[] fruits2 = new string[4];
            fruits2[0] = "Apple";
            fruits2[1] = "Banana";
            fruits2[2] = "Strawberry";
            fruits2[3] = "Kiwi";

            Console.WriteLine();
        }

        private static void ArrayIteration()
        {
            string[] fruits ={   
                "Apple",
                "Banana",
                "Strawberry",
                "Kiwi"
            };

            foreach (string fruit in fruits)
            {
                Console.WriteLine("The fruit is " + fruit);
            }

            Console.WriteLine();
        }
    }
}
