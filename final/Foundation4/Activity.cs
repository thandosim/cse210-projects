public class Activity
{
    protected string _date;
    protected int _length;

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }

    public virtual float GetPace()
    {
        return 0;
    }

    public virtual string Summary()
    {
        return "";
    }


}