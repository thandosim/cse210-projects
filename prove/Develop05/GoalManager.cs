using System.IO.Enumeration;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();

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
            if (option == "2")
            {
                ListGoalDetails();
            }
            if (option=="3")
            {
                SaveGoals();
            }
            if (option=="4")
            {
                LoadGoals();
            }
            if (option=="5")
            {
                RecordEvent();
            }
            if(option == "6")
            {
                return;
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        //display points
        Console.WriteLine($"You have {_score} Points.");        
    }

    public void ListGoalNames()
    {
        //Loop through the list of goals and display their names 
        //create another functiion in Goal class to get the protected names       
    }

    public void ListGoalDetails()
    {
        //loop through the list of goals and display all the details
        
        foreach(var goal in _goals)
        {
            string x = " ";
            if (goal is SimpleGoal simpleGoal)
            {
                if(simpleGoal.GetCompletion()==true)
                {
                    x = "X";
                } 
                Console.WriteLine($"[{x}] {goal.GetName()}  ({goal.GetDescription()}) ");
            }
            else if(goal is EternalGoal eternalGoal)
            {
                Console.WriteLine($"[{x}] {goal.GetName()}  ({goal.GetDescription()}) ");
            }
            else if(goal is ChecklistGoal checklistGoal)
            {
                if(checklistGoal.IsComplete())
                {
                    x = "X";
                }
                Console.WriteLine($"[{x}] {goal.GetName()}  ({goal.GetDescription()}) -- Currently completed: {checklistGoal.GetAmountCompleted()}/{checklistGoal.GetTarget()}");
            }
        }
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
        
        //ask for the name,description and points
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        
        //ask for more if its checklist goal
        if (option1 == "1")
        {
            Console.WriteLine("simple goal");
            SimpleGoal sg = new SimpleGoal(name,description,points);
            _goals.Add(sg);
        }
        if (option1 == "2")
        {
            Console.WriteLine("eternal goal");
            EternalGoal eg = new EternalGoal(name,description,points);
            _goals.Add(eg);
        }

        if (option1 == "3")
        {
            Console.WriteLine("checklist goal");
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write($"What is the bonus for accomplishing it {target} times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal cg = new ChecklistGoal(name,description,points,bonus,target);
            _goals.Add(cg);
        }
        else
        {
            Console.WriteLine("invalid choice");
        }
        //create the object and add to the goal list

    }

    public void RecordEvent()
    {
        //display a list of all the goal names
        Console.WriteLine("The Goals are: ");
        int i = 0;
        foreach (var goal in _goals)
        {
            Console.WriteLine($" {i+1}. {goal.GetName()}");
            i+=1;
        }
        //ask user to select a goal
        Console.Write("What Goal did you accomplish: ");
        int choice = int.Parse(Console.ReadLine())-1;
        //call the Record event on the correct class
        _score += _goals[choice].RecordEvent();
        // update the score based on the points
    }

    public void SaveGoals()
    {
        // ask user for a filename
        Console.Write("What is the file name for the goal file?  ");
        string fileName = Console.ReadLine();
        // loop through the goals and convert
        // eaach to a string and save the string
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach(var goal in _goals)        
            {
                string line = goal.GetStringRepresentation();
                outputFile.WriteLine(line);
            }
        }
        
    }

    public void LoadGoals()
    {
        // ask user for a filename
        Console.Write("What is the file name for the goal file?  ");
        string fileName = Console.ReadLine();
        //read each line of the file and split it up
        string[] lines = System.IO.File.ReadAllLines(fileName);
        //use the parts to recreate the Goal object
        _score = int.Parse(lines[0]);
        List<string> lines2 = new List<string>(lines); 
        lines2.RemoveAt(0);

        foreach(string line in lines2)
        {
            string[] parts = line.Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal sg = new SimpleGoal(name,description,points,isComplete);
                _goals.Add(sg);
            }
            if (type == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(name,description,points);
                _goals.Add(eg);
            }
            if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal cg = new ChecklistGoal(name,description,points,bonus,target,amountCompleted);
                _goals.Add(cg);
            }
        }
    }
}