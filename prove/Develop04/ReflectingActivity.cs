public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayPrompt();
        ShowSpinner(5);
        DisplayQuestions();
        ShowSpinner(5);
        DisplayQuestions();
        ShowSpinner(5);
        DisplayQuestions();
        ShowSpinner(5);
        DisplayEndingMessage(); 
    }
// consider for extra credit
//     ConsoleKey conK = Console.ReadKey(true).Key;
// while (!Console.KeyAvailable && conK != ConsoleKey.L)
// {
//     if (conK == ConsoleKey.N)
//     {
//         // Do something when 'N' key is pressed
//         Console.WriteLine("N key pressed.");
//     }
//     conK = Console.ReadKey(true).Key;
// }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,4);

        return _prompts[number];
    }

    public string GetRandomQuestion()
    {
        return "Question 1";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());        
    }


}