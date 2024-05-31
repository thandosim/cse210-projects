public class SwimmingActivity :Activity
{
    private int _laps;

    public SwimmingActivity(string date,int length, int laps) : base(date,length)
    {
        _laps = laps;
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