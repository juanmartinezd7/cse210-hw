


class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {

    };

    private List<string> _questions = new List<string>
    {

    };

    public ReflectingActivity() : base("Reflecting", "This Activity helps you reflect.") {}

    public override void Run()
    {
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return "";
    }

    private string GetRandomQuestion()
    {
        return "";
    }

    
}

