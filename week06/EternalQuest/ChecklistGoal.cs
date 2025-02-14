


class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            score += _points;
            if (_amountCompleted == _target)
            {
                score += _bonus;
            }
        }
        if (_amountCompleted == _target)
        Console.WriteLine("This goal is already completed.");
        return;
    }

    public void SetProgress(int progress)
    {
        _amountCompleted = progress;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() 
        => ($"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}");

    public override string GetStringRepresentation() 
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }

}