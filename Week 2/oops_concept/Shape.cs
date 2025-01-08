using System;

abstract class Shape
{
    // Encapsulation: Protected fields for dimensions
    protected double dimension1;
    protected double dimension2;

    public void SetDimensions(double dimension1, double dimension2 = 0)
    {
        this.dimension1 = dimension1;
        this.dimension2 = dimension2;
    }

    public abstract double GetArea(); // Abstract method to be implemented by each shape

    public void DisplayArea()
    {
        Console.WriteLine($"The area is: {GetArea()}");
    }
}
