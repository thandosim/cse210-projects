//Creativity:
// i created loading screen and saving screen functions that display a simple dot animation to simulate the loading of the file and saving of the file. 
// the loading  screen is also called at the very begining to imitate a loading game

using System;
class Program
{
    static void Main(string[] args)
    {
        

        // create a Goal manager object and call the start function on that object
        GoalManager myGoals = new GoalManager();

        myGoals.LoadingScreen();
        Console.WriteLine("Welcome to the Eternal Quest Game.");
        Console.WriteLine("You can make meeting your goals a fun activity by using this application.");
        Console.WriteLine("Press enter to Continue");
        Console.ReadLine();
        myGoals.LoadingScreen();
        myGoals.Start();
       
    }
}