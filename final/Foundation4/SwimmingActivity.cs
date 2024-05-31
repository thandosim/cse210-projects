public class SwimmingActivity :Activity
{
    private int _laps;

    public SwimmingActivity(string date,int length, int laps) : base(date,length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps*50/1000;
    }

    public override float GetSpeed()
    {
        return GetDistance()/_length*60;
    }

    public override float GetPace()
    {
        return 60/GetSpeed();
    }
}