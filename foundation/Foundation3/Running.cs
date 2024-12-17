public class Running: Activity
{
    private double _distance;

    public Running(int minutes, DateOnly date, double distance): base(minutes, date)
    {
        _distance = distance;
    }



    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTimeInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }

    public override string GetActivity()
    {
        return "running";
    }
}