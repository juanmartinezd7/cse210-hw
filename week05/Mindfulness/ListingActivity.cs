


using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {

    };

    public ListingActivity() : base("Listing", "This activity helps you reflect") {}

    public override void Run()
    {
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return "";
    }

   
}