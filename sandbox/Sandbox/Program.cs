using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        ConsoleKey conK = Console.ReadKey(true).Key;
        while (!Console.KeyAvailable && conK != ConsoleKey.L)
        {
            // if (conK == ConsoleKey.N)
            // {
            //     // Do something when 'N' key is pressed
            //     Console.WriteLine("N key pressed.");
            // }
            // conK = Console.ReadKey(true).Key;
        }
        // Do something after 'L' key is pressed and the loop breaks

    }
}