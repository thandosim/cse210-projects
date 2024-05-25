using System;

class Program
{
    public static void Main()
{
    int loadingLength = 5; // Number of dots
    Console.Write("Loading...");
    for (int i = 0; i < loadingLength; i++)
    {
        Console.Write(".");
        Thread.Sleep(500); // Simulate loading time
    }
}
}
