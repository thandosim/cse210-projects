public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title,description,date,time,address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {

    }
}