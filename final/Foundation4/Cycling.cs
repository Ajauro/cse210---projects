public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * 0.621371) * (Duration / 60.0); // Convert km to miles
    }

    public override double GetSpeed()
    {
        return _speed * 0.621371; // Convert kph to mph
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}