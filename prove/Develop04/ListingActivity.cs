public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() 
    {  
        //initialising the activity, setting the name and description
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run()
    {
        
        DisplayStartingMessage();// display message to welcome the use to the activity. this will recieve duration iunput from user
        Console.Clear();
        //sequence of actions that result in listing activity.
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(2);
        Console.WriteLine();

        //allow the user to type the list. automatically ends after {_duration} seconds.
         GetListFromUser();
        // currentTime = DateTime.Now;
        
        // display the number of items listed by the user. 
        Console.WriteLine($"You have listed {_count} items.");
        DisplayEndingMessage();

                
    }

    public void GetRandomPrompt()
    {
        //creates and randomly selcts a prompt to display for the user
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,4);
        Console.WriteLine($"--- {_prompts[number]} ---");
    }

    public List<string> GetListFromUser()
    {
        // gets a list from the user and counts entries. this doestn realy do anything but count the entries.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
              
            Console.Write(">  ");
            Console.ReadLine();
            _count += 1;          
        }        
        return [];
    }

}