using ProgrammerenHuiswerk.Framework;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week2Assignment4 : BaseRunable, IWeekProvider, ISingleAssignmentProvider
    {
        public int Week => 2;
        public string AssignmentId => "4";

        public override void Execute()
        {
            int[] firstComponents = {
                1, 5, 8, 9, 2,
            };

            int[] secondComponents = {
                4, 3, 6, 7, 0,
            };

            int[] sums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sums[i] = firstComponents[i] + secondComponents[i];
                Output.Add($"{firstComponents[i]} + {secondComponents[i]} = {sums[i]}");
            }
        }
    }
}
