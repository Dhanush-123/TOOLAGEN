using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string? str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string? str2 = Console.ReadLine();

      
        if (str1 == str2)
        {
            Console.WriteLine("The strings are equal.");
        }
        else
        {
            Console.WriteLine("The strings are not equal.");
        }
    }
}
