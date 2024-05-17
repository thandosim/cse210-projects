public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {  
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.Write("Now breathe out... ");
            ShowCountDown(2);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }     
}