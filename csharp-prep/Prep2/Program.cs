using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade: ");
        string grade_str = Console.ReadLine();
        float grade = int.Parse(grade_str);
        string symbol = "X";
        string sign = "";

        if (grade >= 90)
        {
            symbol = "A" ;
        }
        else if (grade >= 80 && grade < 90)
        {
            symbol = "B" ;
        }
        else if (grade >= 70 && grade < 80)
        {
            symbol = "C" ;
        }
        else if (grade >= 60 && grade < 70)
        {
            symbol = "D" ;
        }
        else if (grade < 60)
        {
            symbol = "F" ;
        }

        if ( grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed!!");
        }
        else 
        {
            Console.WriteLine("Sorry. Please continue trying hard.");
        }

        if (grade%10 >=7)
        {
            sign = "+";
        }
        else if (grade%10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($" {symbol} {sign}");

    }
}