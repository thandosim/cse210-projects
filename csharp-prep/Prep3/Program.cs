using System;

class Program
{
    static void Main(string[] args)
    {
        int guess=0; 
        int magic_number;
        int count = 0;
        
        Random randomGenerator = new Random();
        magic_number = randomGenerator.Next(1,11);
        
        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count = count + 1;
            if (guess == magic_number)
            {
                Console.WriteLine("congratulations, You guessed it!");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine($"It took  you {count} guesses.");
    }
}