using System;

class Program
{
    static void Main()
    {
        try
        {
            int age = GetAge();
            Console.WriteLine($"Age entered: {age}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static int GetAge()
    {
        Console.Write("Please enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age < 0 || age > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Invalid age provided. Age must be between 0 and 100.");
            }
            return age;
        }
        else
        {
            throw new ArgumentException("Invalid input. Please enter a valid numeric age.");
        }
    }
}
