

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This Activity helps you relax by walking you through breathing in and out slowly.\nClear your mind and focus in breathing.") {}

    public override void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            elapsed += 5;
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
            elapsed += 5;
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