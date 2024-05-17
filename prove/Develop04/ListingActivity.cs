public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() 
    {  
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(2);
        Console.WriteLine();

        
         GetListFromUser();
        // currentTime = DateTime.Now;
        

        Console.WriteLine($"You have listed {_count} items.");
        DisplayEndingMessage();

                
    }

    public void GetRandomPrompt()
    {
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
        // ConsoleKey key;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        // DateTime currentTime = DateTime.Now;
        while (DateTime.Now < futureTime)
        {
              
            Console.Write(">  ");
            Console.ReadLine();
            _count += 1;
                        
        }
        
        return [];
    }

}