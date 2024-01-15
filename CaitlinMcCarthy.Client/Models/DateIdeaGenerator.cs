namespace CaitlinMcCarthy.Client.Models;
public class DateIdeaGenerator
{
    private static readonly List<string> DateIdeas = new List<string>
    {
        "Wine and a movie",
        "Play a boardgame",
        "Visit a museum or art gallery",
        "Go for a hike",
        "Go skating",
        "Go to a concert",
        "Go to a comedy show",
        "Go to a sporting event",
        "Have a trivia night",
        "Go to a karaoke bar",
        "Volunteer together",
        "Go to a local festival",
        "Cook a meal together",
        "Go on a bike ride",
        "Plan a trip together"
    };

    private static readonly Random Random = new Random();

    public string GetRandomDateIdea()
    {
        int index = Random.Next(DateIdeas.Count);
        Console.WriteLine($"Date idea: {DateIdeas[index]}");
        return DateIdeas[index];
    }
}
