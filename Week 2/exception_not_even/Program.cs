using System;

namespace EvenNumberValidation
{
    public class NumberValidator
    {
        // Method to validate if a number is even
        public void ValidateEvenNumber(int number)
        {
            if (number % 2 != 0)
            {
                throw new ArgumentException("The provided number is not even.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            NumberValidator validator = new NumberValidator();
            
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            try
            {
                validator.ValidateEvenNumber(inputNumber);
                Console.WriteLine("The number is even.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
