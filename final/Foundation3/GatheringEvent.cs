public class GatheringEvent : Event
{
    private string _weather;

    public GatheringEvent(string title, string description, string date, string time, Address address, string weather) : base(title,description,date,time,address)
    {
        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        
    }
}