public class Cycling: Activity
{
    private int _speed;

    public Cycling(int minutes, DateOnly date, int speed): base(minutes, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetTimeInMinutes())/60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
    
    public override string GetActivity()
    {
        return "cycling";
    }
}