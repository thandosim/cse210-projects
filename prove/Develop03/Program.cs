// i made the HideRandomWords function to randomly choose a number of words to hide from 1 to 3
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference r3 = new Reference("Matthew", 1, 1);
        Scripture s1 = new Scripture(r3,"The quick brown fox jumped over the lazy dog.");

        Console.WriteLine(s1.GetDisplayText());
        s1.HideRandomWords();
        Console.WriteLine(s1.GetDisplayText());

    



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