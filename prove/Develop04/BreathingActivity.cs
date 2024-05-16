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
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }     
}