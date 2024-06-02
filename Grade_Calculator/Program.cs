// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Grade Calculator");
        Console.WriteLine("Please enter grade from 0 - 100: ");

        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if(grade >= 80)
        {
            Console.WriteLine("B");
        }else if(grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if(grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

    }
}
