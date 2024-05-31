public class BicycleActivity : Activity
{
    private float _speed;

    public BicycleActivity(string date,int length, float speed) : base(date,length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed*_length/60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60/GetSpeed();
    }
}