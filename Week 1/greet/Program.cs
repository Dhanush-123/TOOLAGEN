using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        DateTime currentTime = DateTime.Now;

        Console.WriteLine($"HI, {name}! Welcome, and the time is {currentTime:hh:mm tt}. ");

    }
}

