public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts;

    public ReflectingActivity(string name, string description, int duration)
    : base(name,description,duration)
    {

    }

    public void Run()
    {
        
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {
        
    }


}