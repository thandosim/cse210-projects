public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title,description,date,time,address)
    {
        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine(GetType());
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.GetAddressString());
        Console.WriteLine(_weather); 
    }
}