using System;
using System.Collections.Generic;

namespace StudentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store student names and scores
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            Console.WriteLine("Enter the number of students:");
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Score: ");
                int score = int.Parse(Console.ReadLine());

                // Add the name and score to the dictionary
                studentScores[name] = score;
            }

            Console.WriteLine("\nStudent Scores:");
            foreach (var student in studentScores)
            {
                Console.WriteLine($"Name: {student.Key}, Score: {student.Value}");
            }
        }
    }
}
