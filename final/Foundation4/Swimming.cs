public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0) * 0.621371; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Duration / 60.0);
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}