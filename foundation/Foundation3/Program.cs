using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(30, new DateOnly(2024, 12, 12), 7.2);
        Swimming swim = new Swimming(25, new DateOnly(2024, 12, 13), 40);
        Cycling cycling = new Cycling(50, new DateOnly(2024, 12, 15), 25);

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(swim);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}