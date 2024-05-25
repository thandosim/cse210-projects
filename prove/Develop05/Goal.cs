public abstract class Goal
{
    //Attributes set to protected later
    public string _shortName;
    public string _description;
    public int _points;

    //constructor(name,description,points)
    public Goal(string shortName, string description,int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();


    public abstract bool IsComplete();


    public string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringDescription();
}