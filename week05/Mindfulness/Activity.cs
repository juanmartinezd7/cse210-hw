

using System.Net;

abstract class  Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    
   public void DisplayStartingMessage()
   {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);

    while (true)
    {
        Console.WriteLine();
        Console.Write("How long in seconds would you like for your session? ");
        
        
        try
        {
            _duration = int.Parse(Console.ReadLine());

            if (_duration > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number greater than 0.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
    Console.Clear();

    Console.WriteLine("Get ready...");
    ShowAnimation(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! You have completed the activity. ");
        Console.WriteLine($"You spent {_duration} seconds on {_name}.");
        ShowAnimation(5);
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Go.");
    }
    public abstract void Run();
    
}