// Exceeding requiements:  th code is run in a while loop so that the user is presented with the menu
// and can exit the program by pressing 0. 

using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
       int choice = 110;
       string fileName = "myJournal.txt";
       Journal theJournal = new Journal();

       while (choice != 0)
       {
            Console.WriteLine("Enter the number and press enter");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("0. Exit.");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {   
                PromptGenerator prompt1 = new PromptGenerator();
                Entry anEntry = new Entry();
                anEntry._promptText = prompt1.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                anEntry._date = dateText;

                Console.WriteLine("type your journal entry: ");
                anEntry._entryText = Console.ReadLine();

                anEntry.Display();

                theJournal.AddEntry(anEntry);

            }
            
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                theJournal.LoadFromFile(fileName);
            }
            
            else if (choice == 4)
            {
                theJournal.SaveToFile(fileName);
            }

       }

       



    }
}