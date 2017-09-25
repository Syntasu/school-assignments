using ProgrammerenHuiswerk.Framework;
using System.Collections.Generic;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson2Assignment2 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        private int ictionary;

        public int Week => 1;
        public int Lesson => 2;
        public string AssignmentId => "2";

        public override void Execute()
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "nl", "Tot ziens!"},
                { "fr", "Au revoir!"},
                { "frl", "Oant sjens!"},
                { "en", "Bye!"}
            };

            Output.Add("In welke taal moet het woordje `tot ziens` worden weer gegeven?");
            Output.Add("De opties zijn: Nederlands(NL), Engels(EN), Fries(FRL) en Frans(FR)");

            AssignmentHelper.RequestInput(this, "Typ de twee of driecijferige code in", out string language);

            string result = "";
            if (dictionary.TryGetValue(language.ToLower(), out result))
            {
                Output.Add($"Tot ziens in {language.ToUpper()} is {result}");
            }
            else
            {
                Output.Add("Onbekende taal :(");
            }
        }
    }
}
