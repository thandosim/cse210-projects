public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title,description,date,time,address)
    {
        _email = email;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(GetType());
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.GetAddressString());
        Console.WriteLine(_email); 
    }
}