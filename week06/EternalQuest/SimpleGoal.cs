

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
        }

        if (_isComplete == true)
        {
            Console.WriteLine("This goal is already completed.");
            return;
        }
    }

    public void SetCompletion(bool completed)
    {
        _isComplete = completed;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => ($"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})");

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    

}