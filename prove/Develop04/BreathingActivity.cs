public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {  
         //initialising the activity, setting the name and description
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        // display message to welcome the use to the activity. this will recieve duration iunput from user
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            //sequence of actions that result in breathing activity.
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