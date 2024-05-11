// i made the HideRandomWords function to randomly choose a number of words to hide from 1 to 3
// consider not hiding special characters as extra credit stuff
// ----Added a counter that quits the program once the user presses enter more times than there are words in the verse. 
//     This helps is the code gets stuck searching for visible words when there are none 
using System;

class Program
{
    static void Main(string[] args)
    {
     

        Reference r3 = new Reference("Helaman", 5, 12);
        Scripture s1 = new Scripture(r3,"And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        string option = "";
        int quiter = 0;
        Console.Clear();
        Console.WriteLine(s1.GetDisplayText());
        option = Console.ReadLine();
        
        while (option !="quit")
        {
            s1.HideRandomWords();
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());
            //Console.WriteLine(s1.IsCompletelyHidden());
            option = Console.ReadLine();
            quiter +=1;
            if (s1.IsCompletelyHidden() == true)
            {
                option = "quit";
            }
            else if(quiter==s1.getNumberOfWords())
            {
                option = "quit";
            }

        }
        

    



        // uncomment to test Reference
        // Reference r = new Reference("Matthew", 1, 1, 3);
        // Console.WriteLine(r.GetDisplayText());

        // Reference r2 = new Reference("Matthew", 1, 1);
        // Console.WriteLine(r2.GetDisplayText());

        // uncomment to test Word class
        // Word w = new Word("teset");
        // Console.WriteLine(w.GetDisplayText());

        // w.Hide();
        // Console.WriteLine(w.GetDisplayText());

    }
}