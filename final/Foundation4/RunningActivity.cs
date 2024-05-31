public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string date,int length, float distance) : base(date,length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return 0;
    }

    public override float GetSpeed()
    {
        return 0;
    }

    public override float GetPace()
    {
        return 0;
    }

    public override string Summary()
    {
        return "";
    }
}