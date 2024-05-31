public class BicycleActivity : Activity
{
    private float _speed;

    public BicycleActivity(string date,int length, float speed) : base(date,length)
    {
        _speed = speed;
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