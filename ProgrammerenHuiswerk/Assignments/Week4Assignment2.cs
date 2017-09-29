using ProgrammerenHuiswerk.Framework;
using System;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week4Assignment2 : BaseRunable, IWeekProvider, IMultipleAssignmentsProvider
    {
        public int Week => 4;
        public string[] AssignmentIds => new[] { "2.1", "2.2", "2.3", "2.4", "2.5", "2.6" };

        public override void Execute()
        {
            string text = "train";

            char derdeLetter = DerdeLetter(text);
            Output.Add($"Derde letter van {text} is {derdeLetter}");

            Output.Add("");
            Output.Add("Q: Word inderdaad de 3rde letter afgedrukt?");
            Output.Add("A: Ja.");

            Output.Add("");
            int index = 2;
            char letter = LetterN(text, index);
            Output.Add($"De letter op index {index} van {text} is {letter}");

            Output.Add("");
            Output.Add("Q: Wat gebeurt er als je de waarde 0, of kleiner dan 0 meegeeft?");
            Output.Add("A: Een IndexOutOfRange exception");

            Output.Add("");
            Output.Add("Q: Wat gebeurt er als je een waarde opgeeft die groter is dan de lengte van de tekst?");
            Output.Add("A: Een IndexOutOfRange exception");

            Output.Add("");
            Output.Add("We loopen over de string, beginnen bij de lengte in het negatief tot 2x de lengte");
            Output.Add("Normaal zou dit een IndexOutOfBounds exception geven.");

            for (int i = -text.Length; i < text.Length * 2; i++)
            {
                char l = LetterNSafe(text, i);

                if(l != (char)0)
                {
                    Output.Add($"{i} heeft een waarde van {l}");

                }
                else
                {
                    Output.Add($"{i} heeft geen waarde");
                }
                
            }

        }

        private char DerdeLetter(string text)
        {
            return text[2];

        }

        private char LetterN(string word, int index)
        {
            return word[index - 1];
        }

        private char LetterNSafe(string word, int index)
        {
            if (index < 0 || index > word.Length - 1) return (char)0;
            return word[index];
        }
    }
}
