using System;

class Program
{
    // Generic method to swap two variables of any type
    public static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    }

    static void Main(string[] args)
    {
        // Get user input for two numbers
        Console.WriteLine("Enter the first number:");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int secondNum = int.Parse(Console.ReadLine());

        // Display the values before swapping
        Console.WriteLine($"\nBefore swapping:\nFirst number: {firstNum}\nSecond number: {secondNum}");

        // Call the Swap method
        Swap(ref firstNum, ref secondNum);

        // Display the values after swapping
        Console.WriteLine($"\nAfter swapping:\nFirst number: {firstNum}\nSecond number: {secondNum}");

        // Get user input for two strings
        Console.WriteLine("\nEnter the first string:");
        string firstStr = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string secondStr = Console.ReadLine();

        // Display the string values before swapping
        Console.WriteLine($"\nBefore swapping:\nFirst string: {firstStr}\nSecond string: {secondStr}");

        // Call the Swap method for strings
        Swap(ref firstStr, ref secondStr);

        // Display the values after swapping
        Console.WriteLine($"\nAfter swapping:\nFirst string: {firstStr}\nSecond string: {secondStr}");
    }
}
