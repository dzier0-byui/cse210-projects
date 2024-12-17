public abstract class Activity
{
    private int _timeInMinutes;
    private DateOnly _dateCompleted;

    public Activity(int minutes, DateOnly date)
    {
        _timeInMinutes = minutes;
        _dateCompleted = date;
    }

    public int GetTimeInMinutes()
    {
        return _timeInMinutes;
    }

    public DateOnly GetDate()
    {
        return _dateCompleted;
    }

    public abstract string GetActivity();

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace(); 

    public virtual string GetSummary()
    {
        return $"{_dateCompleted.ToString("dd MMM yyyy")} {GetActivity()} ({_timeInMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}