public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventName, string description, string date, string time, Address address, string weather)
        : base(eventName, description, date, time, address)
    {
        this._weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather: {_weather}";
    }
}