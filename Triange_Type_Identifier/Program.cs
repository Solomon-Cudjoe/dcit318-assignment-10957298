// See https://aka.ms/new-console-template for more information
using System;

class Triangle_Identifier
{
     static void Main(string[] args)
    {
        Console.WriteLine("Triangle Type Identifier");

        Console.WriteLine("Enter first side length: ");
        int firstSide = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second side length: ");
        int secondSide = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third side length: ");
        int thirdSide = int.Parse(Console.ReadLine());

        if(firstSide == secondSide && secondSide == thirdSide) {
            Console.WriteLine("Equilateral");
        }
        else if(firstSide == thirdSide  || secondSide == thirdSide || firstSide == thirdSide) {
        Console.WriteLine("Isosceles");
        }
        else
        {
            Console.WriteLine("Scalene");
        }
    }
}
