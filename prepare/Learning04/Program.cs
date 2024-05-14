using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assign1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Mary Waters", "Europian History", "The Causes of World War II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}