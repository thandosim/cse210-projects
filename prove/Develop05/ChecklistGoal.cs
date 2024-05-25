public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name,string description, int points,int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //make another constructor for when reading these from a file

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return "";
    }

    public override string GetStringDescription()
    {
        return "";
    }
}