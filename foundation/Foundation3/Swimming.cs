public class Swimming: Activity
{
    private int _laps;

    public Swimming(int minutes, DateOnly date, int laps): base(minutes, date)
    {
        _laps = laps;   
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTimeInMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }
    
    public override string GetActivity()
    {
        return "swimming";
    }
}