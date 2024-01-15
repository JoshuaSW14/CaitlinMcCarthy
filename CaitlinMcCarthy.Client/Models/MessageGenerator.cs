namespace CaitlinMcCarthy.Client.Models;
public class MessageGenerator
{
    private static readonly List<string> Messages = new List<string>
    {
        "I hope you have a good day!",
        "Thinking of you always makes me smile.",
        "You mean the world to me.",
        "I'm so lucky to have you in my life.",
        "Every moment with you is precious.",
        // Add more messages here
    };

    public string GetRandomMessage()
    {
        return Messages[new Random().Next(0, Messages.Count)];
    }
}
