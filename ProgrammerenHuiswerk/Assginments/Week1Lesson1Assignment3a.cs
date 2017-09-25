using ProgrammerenHuiswerk.Framework;

namespace ProgrammerenHuiswerk.Assginments
{
    public class Week1Lesson1Assignment3a : BaseRunable, IWeekProvider, ILessonProvider, ISingleAssignmentProvider
    {
        public int Week => 1;
        public int Lesson => 1;
        public string AssignmentId => "3a";

        public override void Execute()
        {
            Output.Add("Q: Welke datatypes gebruik je? Motiveer je keuze");
            Output.Add("");
            Output.Add("A:\n - doubles, omdat temperaturen vaak decimale waarde kunnen hebben. \n - string, om de gebruikers input te verkrijgen en in op te slaan. \n - char, voor de aanduiding van de(temperatuur) eenheid.");
        }
    }
}
