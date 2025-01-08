using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the shape (Circle, Triangle, Rectangle):");
        string shapeType = Console.ReadLine().ToLower();

        Shape shape = null;

        if (shapeType == "circle")
        {
            shape = new Circle();
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            shape.SetDimensions(radius);
        }
        else if (shapeType == "triangle")
        {
            shape = new Triangle();
            Console.WriteLine("Enter base:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = Convert.ToDouble(Console.ReadLine());
            shape.SetDimensions(baseLength, height);
        }
        else if (shapeType == "rectangle")
        {
            shape = new Rectangle();
            Console.WriteLine("Enter length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width:");
            double width = Convert.ToDouble(Console.ReadLine());
            shape.SetDimensions(length, width);
        }
        else
        {
            Console.WriteLine("Invalid shape.");
            return;
        }

        // Display the area of the shape
        shape.DisplayArea();
    }
}
