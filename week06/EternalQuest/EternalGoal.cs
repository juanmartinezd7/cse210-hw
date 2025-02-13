


class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent(ref int score)
    {

    }

    public override bool IsComplete()
    {
        return  false;
    }

    public override string GetDetailsString()
    {
        return " ";
    }

    public override string GetStringRepresentation() 
    {
        return " ";
    }

}