using System;

class Triangle : Shape
{
    public override double GetArea()
    {
        double baseLength = base.dimension1;  // Accessing dimension1 (base)
        double height = base.dimension2;  // Accessing dimension2 (height)
        return 0.5 * baseLength * height;
    }
}
