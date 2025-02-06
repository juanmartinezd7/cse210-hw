

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
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {

    }

    protected void ShowAnimation(int seconds)
    {

    }

    public abstract void Run();
    
        
    
    
}