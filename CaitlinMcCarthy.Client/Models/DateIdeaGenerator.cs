namespace CaitlinMcCarthy.Client.Models;
public class DateIdeaGenerator
{
    private static readonly List<string> DateIdeas = new List<string>
    {
        "Watch a movie under the stars.",
        "Have a picnic in the park.",
        "Visit a museum or art gallery.",
        "Go for a scenic hike.",
        "Try a new restaurant in town.",
        // Add more ideas here
    };

    private static readonly Random Random = new Random();

    public string GetRandomDateIdea()
    {
        int index = Random.Next(DateIdeas.Count);
        return DateIdeas[index];
    }
}
