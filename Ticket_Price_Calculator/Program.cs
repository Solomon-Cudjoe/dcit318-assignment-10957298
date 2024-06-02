// See https://aka.ms/new-console-template for more information
using System;
class Price_Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ticket Price Calculator");

        Console.WriteLine("Please enter your age: ");

        int age = int.Parse(Console.ReadLine());
        int ticketPrice = (age >= 65 || age <= 12) ? age * 7 : 10;
        Console.WriteLine("Ticket Price: GHC" + ticketPrice);
    }
}
