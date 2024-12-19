using System;

public class Program
{
    public static void Main()
    {
        // Define a Func delegate that takes two integers and returns their sum
        Func<int, int, int> addNumbers = (a, b) => a + b;

        // Get input from the user
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Call the delegate to add the two numbers
        int result = addNumbers(num1, num2);

        // Display the result
        Console.WriteLine("The sum is: " + result);
    }
}
