public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() 
    {  
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        ShowCountDown(3);
        GetListFromUser();        
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("promt 1");
    }

    public List<string> GetListFromUser()
    {
        return [];
    }



}