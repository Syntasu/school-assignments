using ProgrammerenHuiswerk.Framework;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week4Assignment1a : BaseRunable, IWeekProvider, IMultipleAssignmentsProvider
    {
        public int Week => 4;
        public string[] AssignmentIds => new[] { "1.1", "1.2" };

        public override void Execute()
        {
            string a = "Nederland";
            string middleLetterA = FindSingleMiddleLetter(a);
            Output.Add($"De middelste letter van {a} is {middleLetterA}");

            string b = "Engeland";
            string middleLetterB = FindMultipleMiddleLetters(b);
            Output.Add($"De middelste letters van {b} is {middleLetterB}");
        }

        public string FindSingleMiddleLetter(string input)
        {
            int middle = input.Length / 2;
            return input.Substring(middle, 1);
        }

        public string FindMultipleMiddleLetters(string input)
        {
            if (input.Length % 2 != 0)
            {
                return input.Substring(input.Length / 2, 1);
            }
            else
            {
                return input.Substring((input.Length / 2) - 1, 2);
            }
        }
    }
}
