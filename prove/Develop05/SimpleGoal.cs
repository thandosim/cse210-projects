public class SimpleGoal : Goal
{
    public bool _isComplete;

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
        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_description}|{_points}|{_isComplete}";
    }

    

}