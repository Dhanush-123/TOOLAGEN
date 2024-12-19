using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentFilter
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public double GPA { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Enter the number of students:");
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Enter details for Student {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("GPA: ");
                double gpa = double.Parse(Console.ReadLine());

                students.Add(new Student { Name = name, GPA = gpa });
            }

            // Filter students with GPA > 3.5 using LINQ
            var filteredStudents = students.Where(s => s.GPA > 3.5).ToList();

            Console.WriteLine("\nStudents with GPA greater than 3.5:");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Name: {student.Name}, GPA: {student.GPA}");
            }
        }
    }
}
