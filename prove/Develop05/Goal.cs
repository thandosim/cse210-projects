public class Goal
{
    //Attributes set to protected later
    protected string _shortName;
    protected string _description;
    protected int _points;

    //constructor(name,description,points)
    public Goal(string shortName, string description,int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    // public abstract string GetName();

    public virtual bool IsComplete()
    {
        return false;
    }


    public string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
}