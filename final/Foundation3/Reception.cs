public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventName, string description, string date, string time, Address address, string rsvpEmail)
        : base(eventName, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
    }
}