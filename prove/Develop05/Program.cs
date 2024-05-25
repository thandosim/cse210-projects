using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        List<Goal> goals = new List<Goal>();
        SimpleGoal sg= new SimpleGoal("","",0,false);
        goals.Add(sg);

        Goal g = goals[0];

        // create a Goal manager object and call the start function on that object
        GoalManager myGoals = new GoalManager();
        myGoals.Start();
       
    }
}