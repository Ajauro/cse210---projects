public abstract class Activity
{
    protected DateTime _date;
    protected int _duration; // in minutes

    public Activity(string date, int duration)
    {
        _date = DateTime.Parse(date);
        _duration = duration;
    }

    public string Date => FormatDate(_date);

    public int Duration => _duration;

    public virtual double GetDistance()
    {
        return 0.0; // Default implementation
    }

    public virtual double GetSpeed()
    {
        return 0.0; // Default implementation
    }

    public virtual double GetPace()
    {
        return 0.0; // Default implementation
    }

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Duration} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile\n";
    }

    private string FormatDate(DateTime date)
    {
        string month = date.ToString("MMM");
        month = char.ToUpper(month[0]) + month.Substring(1);
        return $"{date:dd} {month} {date:yyyy}";
    }
}