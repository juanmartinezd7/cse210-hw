using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3.5),
            new Cycling(DateTime.Now, 40, 15.0),
            new Swimming(DateTime.Now, 25, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}