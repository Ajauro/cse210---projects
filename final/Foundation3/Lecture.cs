public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventName, string description, string date, string time, Address address, string speaker, int capacity)
        : base(eventName, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity} guests";
    }
}
