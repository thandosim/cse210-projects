using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        string option;

        option = "";
        do
        {
            Console.WriteLine("Welcome to the mindfulness program. please type the number of the activity that your want, or type 4 to exit.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("type your selection and press enter. : ");
            option = Console.ReadLine();

            if (option == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if (option == "2")
            {

            }

            else if (option == "3")
            {

            }

            else if (option == "4")
            {
                Console.WriteLine("the program will end in 3..2..1..--");
            }

        }
        while (option != "4");
    }
}