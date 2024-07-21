public class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance * 0.621371; // Convert km to miles
    }

    public override double GetSpeed()
    {
        return (_distance * 0.621371) / (Duration / 60.0); // Convert km to miles
    }

    public override double GetPace()
    {
        return Duration / (_distance * 0.621371); // Convert km to miles
    }
}