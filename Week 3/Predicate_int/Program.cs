using System;

public class Program
{
    public static void Main()
    {
        // Define a Predicate delegate to check if a number is positive
        Predicate<int> isPositive = number => number > 0;

        Console.Write("Enter the number of values you want to test: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int number = int.Parse(Console.ReadLine());

            // Test if the number is positive
            bool result = isPositive(number);
            Console.WriteLine($"Is {number} positive? {result}");
        }
    }
}
