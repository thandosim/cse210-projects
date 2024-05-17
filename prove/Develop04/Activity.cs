public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?: ");
        _duration = int.Parse(Console.ReadLine());
        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}. ");    
        ShowSpinner(3);
        Console.Clear(); 
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("\\");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(seconds*100);
        Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        Console.Write("3");
        Thread.Sleep(seconds*500);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(seconds*500);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(seconds*500);
        Console.Write("\b \b");
        Console.Write("0");
        Thread.Sleep(seconds*500);
        Console.Write("\b \b");
    }
    
}