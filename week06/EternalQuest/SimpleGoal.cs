

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent(ref int score)
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return " ";
    }

    public override string GetStringRepresentation()
    {
        return  " ";
    }

    

}