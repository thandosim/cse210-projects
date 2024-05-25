public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name,string description, int points) : base(name,description,points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name,string description, int points, bool isComplete) : base(name,description,points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete=IsComplete();
        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public bool GetCompletion()
    {
        return _isComplete;
    }

    

}