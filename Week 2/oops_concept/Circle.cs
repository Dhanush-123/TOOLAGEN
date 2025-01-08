using System;

class Circle : Shape
{
    public override double GetArea()
    {
        double radius = base.dimension1; // Accessing dimension1 (radius)
        return Math.PI * radius * radius;
    }
}
