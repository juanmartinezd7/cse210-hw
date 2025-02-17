

abstract class Activity
{
    private DateTime date;
    private int duration; //duration in minutes.

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - {this.GetType().Name} ({duration} min): Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace {GetPace():0.00} min/mile";
    }
}