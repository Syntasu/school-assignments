using ProgrammerenHuiswerk.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week2Assignment1 : BaseRunable, IWeekProvider, ISingleAssignmentProvider
    {
        public int Week => 2;
        public string AssignmentId => "1";

        public override void Execute()
        {
            int[] values = new int[3];

            for (int i = 0; i < 3; i++)
            {
                AssignmentHelper.RequestInput(
                    this,
                    "Voer een getal in",
                    out int number
                );

                values[i] = number;
            }

            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            Output.Add($"De som van de waarden is {sum}");
        }
    }
}
