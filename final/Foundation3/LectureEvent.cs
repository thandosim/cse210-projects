public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title,description,date,time,address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(GetType());
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.GetAddressString());
        Console.WriteLine(_speakerName);
        Console.WriteLine(_capacity); 
    }
}