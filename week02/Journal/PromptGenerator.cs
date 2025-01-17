
public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What made you happy today?",
            "Did you learn anything new today?",
            "What are you thankful for?",
            "What was the best part of your day?",
            "What was something that inspired you today?",
            "What are your plans for the next week?",
            "What is something good you did today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}