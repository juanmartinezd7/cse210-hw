

class Cycling : Activity
{
    private double speed; // in miles per hour.

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Duration) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}