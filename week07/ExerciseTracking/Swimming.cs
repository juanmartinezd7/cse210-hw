


class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50 / 1000.0) * 0.62;
    public override double GetSpeed() => (GetDistance() / Duration) * 60;
    public override double GetPace() => Duration /GetDistance();

}