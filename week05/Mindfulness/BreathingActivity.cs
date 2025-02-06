

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This Activity helps you relax.") {}

    public override void Run()
    {
        DisplayEndingMessage();
    }

    private void ShowCountDown(int seconds)
    {
        
    }
}