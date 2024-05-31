public class Event
{
   protected string _title;
   protected string _description;
   protected string _date;
   protected string _time;
   protected Address _address;

   public Event(string title, string description, string date, string time, Address address)
   {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
   }

    public void DisplayShortDetails()
    {
        Console.WriteLine(GetType());
        Console.WriteLine(_title);
        Console.WriteLine(_date);
    }

    public void DisplayBaseDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.GetAddressString());        
    }
    
    public virtual void DisplayFullDetails()
    {
        
    }
}