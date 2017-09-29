using System;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week4
    {
        private Random rand = new Random();

        public Week4()
        {
            WriteLine("--- WEEK 4 OPGAVE 2.1---\n");
            Opgave2_1();


            WriteLine("--- WEEK 4 OPGAVE 2.2, 2.3, 2.4, 2.5 en 2.6---\n");
            Opgave2_2To2_6();
        }


        public void Opgave2_1()
        {
            string word1 = "Hello";
            string word2 = "World";

            WriteLine($"The third character of {word1} is {ThirdLetter(word1)}");
            WriteLine($"The third character of {word2} is {ThirdLetter(word2)}");
        }

        public void Opgave2_2To2_6()
        {
            int index1 = 3;
            string word1 = "Trains";

            int index2 = 4;
            string word2 = "Boats";

            WriteLine($"The character at {index1} of {word1} is {LetterN(word1, index1)}");
            WriteLine($"The character af {index2} of {word2} is {LetterN(word2, index2)}");

            /*
             4. Wat gebeurt er als je de waarde 0, of kleiner dan 0 meegeeft?
                Index out of bounds exception, omdat de index niet bestaat in de string.

             5. Wat gebeurt er als je een waarde opgeeft die groter is dan de lengte
              van de tekst?
                Index out of bounds exception, omdat de index niet bestaat in de string.
             */

            WriteLine();
            string word3 = "Auto";
            for (int i = -word3.Length; i < word3.Length * 2; i++)
            {
                char fetched = LetterNSafe(word3, i);

                if (fetched != (char)0)
                {
                    WriteLine($"The character at {i} of {word3} is {LetterNSafe(word3, i)}");
                }
                else
                {
                    WriteLine($"Index {i} is not a valid index");
                }
            }
        }

        private char ThirdLetter(string word)
        {
            return word[2];

        }

        private char LetterN(string word, int index)
        {
            return word[index - 1];
        }

        private char LetterNSafe(string word, int index)
        {
            if (index <= 0 || index > word.Length) return (char)0;
            return word[index - 1];
        }
    }
}
