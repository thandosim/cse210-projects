using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(6,7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction();
        f4.SetTop(3);
        Console.WriteLine(f4.GetTop());
        f4.SetBottom(4);
        Console.WriteLine(f4.GetBottom());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        
    }
}