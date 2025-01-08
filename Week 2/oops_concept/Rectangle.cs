using System;

class Rectangle : Shape
{
    public override double GetArea()
    {
        double length = base.dimension1;  // Accessing dimension1 (length)
        double width = base.dimension2;  // Accessing dimension2 (width)
        return length * width;
    }
}
