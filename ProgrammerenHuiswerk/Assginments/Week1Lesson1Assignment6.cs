using ProgrammerenHuiswerk.Framework;

namespace ProgrammerenHuiswerk.Assignments
{
    public class Week1Lesson1Assignment6 : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string AssignmentId => "6";

        public override void Execute()
        {
            AssignmentHelper.RequestInput(this, "Wat is je voornaam?", out string name);
            AssignmentHelper.RequestInput(this, "Wat is je achternaam?", out string lastName);
            AssignmentHelper.RequestInput(this, "In welke straat woon je?", out string street);
            AssignmentHelper.RequestInput(this, "Wat is je huisnummer?", out string houseNumber);
            AssignmentHelper.RequestInput(this, "Wat is je postcode?", out string postalCode);
            AssignmentHelper.RequestInput(this, "In welke stad of dorp woon je?", out string city);

            Output.Add("");
            Output.Add("Output:");
            Output.Add("");

            Output.Add("===================================================");
            Output.Add(string.Format("| {0,-22} | {1,-22} |", name, lastName));
            Output.Add(string.Format("| {0,-22} | {1,-22} |", street, houseNumber));
            Output.Add(string.Format("| {0,-22} | {1,-22} |", postalCode, city));
            Output.Add("===================================================");
        }
    }
}
