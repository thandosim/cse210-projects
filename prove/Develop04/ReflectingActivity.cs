public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts;

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
        
        return "Prompt 1";
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