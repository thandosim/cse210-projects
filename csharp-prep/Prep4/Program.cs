using System;

class Program
{
    static void Main(string[] args)
    {
        float number = -1;
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0 )
        {
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }
        float total = numbers.Sum();
        float  average = numbers.Average();
        float largest = numbers.Max();
        numbers.ForEach(Console.WriteLine);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: : {average}");
        Console.WriteLine($"The largest is: : {largest}");
    }
}