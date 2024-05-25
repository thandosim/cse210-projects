public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        //List<Goal> goals = new List<Goal>();
        SimpleGoal sg = new SimpleGoal("get","get married inn the temple", 500, false);
    }

    public void Start()
    {
        // display the main menu and call all the other functions
        string option = "";
        while (option != "6")
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("     1. Create a New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            option= Console.ReadLine();

            if(option == "1")
            {
                CreateGoal();
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        //display points        
    }

    public void ListGoalNames()
    {
        //LoopExpression through the list of goals and display their namespace 
        //create another functiion in Goal class to get the protected names       
    }

    public void ListGoalDetails()
    {
        //loop through the list of goals and display all the details
    }

    public void CreateGoal()
    {
        //display a submenu to select goal type
        Console.WriteLine();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string option1= Console.ReadLine();
        if (option1 == "1")
        {
            Console.WriteLine("simple goal");
        }
        //ask for the name,description and points
        //ask for more if its checklist goal
        //create the object and add to the goal list
    }

    public void RecordEvent()
    {
        //display a list of all the goal names
        //ask user to select a goal
        //call the Record event on the correct class
        // update the score based on the points
    }

    public void SaveGoals()
    {
        // ask user for a filename
        // loop through the goals and convert
        // eaach to a string and save the string
    }

    public void LoadGoals()
    {
        // ask usser for a filename
        //read each line of the file and split it up
        //use the parts to recreate the Goal object
    }

}