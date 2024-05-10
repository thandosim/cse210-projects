using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Word w = new Word("teset");
        Console.WriteLine(w.GetDisplayText());

        w.Hide();
        Console.WriteLine(w.GetDisplayText());

    }
}