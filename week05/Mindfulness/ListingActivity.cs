


using System.Net;
using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect the good things in your life by having you list as many things as you can in a certain area.") {}

    public override void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountDown(9);

        List<string> items = new List<string>();
        int elapsed = 0; 
        Console.WriteLine("Start listing items: (Press Enter after each item)");
        while (elapsed < _duration)
        {
            Console.Write("\r> ");
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    items.Add(item);
                }
            }
            Thread.Sleep(1000);
            elapsed++;
        }
        Console.WriteLine($"You listed {items.Count} items!");
        Console.Write("Take a look to what you wrote, press X key when ready to leave. ");
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.X)
                {
                    break;
                }
            }
        }
        
        DisplayEndingMessage();
    }

    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

   
}