using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a list to store favorite fruits
        List<string> favoriteFruits = new List<string>();

        Console.Write("How many favorite fruits do you want to add? ");
        int count = int.Parse(Console.ReadLine());

        // Get favorite fruits from the user
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter fruit {i + 1}: ");
            string fruit = Console.ReadLine();
            favoriteFruits.Add(fruit);
        }

        // Loop through the list and print each fruit
        Console.WriteLine("\nYour favorite fruits are:");
        foreach (string fruit in favoriteFruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
