using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the journal. Choose an option from the menu.");

       int choice = 100;

       while (choice != 0)
       {
            Console.WriteLine("Enter the number and press enter");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {   
                PromptGenerator prompt1 = new PromptGenerator();
                anEntry._promptText = prompt1.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                
                Console.Write("Enter the date: ");
                Entry anEntry = new Entry();
                anEntry._date = Console.ReadLine();
                // anEntry._promptText = 
                // anEntry._entryText = 

            }
            
            else if (choice == 2)
            {

            }

            else if (choice == 3)
            {

            }
            
            else if (choice == 4)
            {

            }

       }

       



    }
}