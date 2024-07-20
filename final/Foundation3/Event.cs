// Classe base
public class Event
{
    private string _eventName;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventName, string description, string date, string time, Address address)
    {
        this._eventName = eventName;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Name: {_eventName}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails(); // Corrigido o retorno para chamar GetStandardDetails
    }

    public string GetShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nEvent Name: {_eventName}\nDate: {_date}";
    }
}