using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of numbers from 1 to 10
        List<int> numbers = Enumerable.Range(1, 10).ToList();

        // Get user input to check if they want to see even numbers
        Console.WriteLine("Do you want to see even numbers? (yes/no)");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "yes")
        {
            // Use LINQ to filter and get even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            // Display the filtered even numbers
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("You chose not to display even numbers.");
        }
    }
}
