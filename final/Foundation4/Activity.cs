class Activity
{
    private string _date;
    private int _lengthInMinutes;
    private string _activityName;

    public Activity(string date, int lengthInMinutes, string activityName)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
        _activityName = activityName;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_lengthInMinutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}