public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>();
    private List<string> _prompts = new List<string>();
    private List<int> _tracker = new List<int>();

    public ReflectingActivity()
    {
         //initialising the activity, setting the name and description, and generating list of questions to choose from randomly
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _tracker = [];
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?"); 
    }

    public void Run()
    {
        //sequence of actions that result in reflecting activity.
        DisplayStartingMessage(); // display message to welcome the use to the activity. this will recieve duration iunput from user
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        ConsoleKey conK = Console.ReadKey(true).Key;
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(2);        
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            //randomly displays questions after 5 seconds. 
            DisplayQuestions();
            ShowSpinner(5);
            currentTime = DateTime.Now;
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        //creates and randomly selcts a prompt to display for the user
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,3);
        return _prompts[number];
    }

    public string GetRandomQuestion()
    {
        //randomly selects and returns a question from the list to display, avoids repeating untill all questions are displayed.
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,9);

        while (_tracker.Contains(number))//if questo=ion is already displayed,
        {
            number = randomGenerator.Next(0,9);//generate another question
            // _tracker.Add(number);
        }
        _tracker.Add(number);//keep track of displayed questions

        if (_tracker.Count() == 9)
        {
            _tracker.Clear();
            return null; //To exit the method without returning the required string.
        }       


        return _questions[number]; //return the question to display
    }

    public void DisplayPrompt()
    {
        //display a random prompt
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        //display a random question
        Console.WriteLine($"> {GetRandomQuestion()}");        
    }


}