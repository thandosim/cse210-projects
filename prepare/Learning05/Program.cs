using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square1 = new Square("red", 2);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("blue",3,2);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("orange", 1);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());
    }
}