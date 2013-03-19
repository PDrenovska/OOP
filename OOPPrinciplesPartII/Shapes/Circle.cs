namespace Shapes
{
    using System;

    // A class inheriting from base class Shape would have to implement the CalculateSurface method;
    public class Circle : Shape
    {
        // Defining a suitable constructor, that on initialization height is kept equal to width;
        // A constructor can use the base keyword to call the constructor of a base class;
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        // Each implemented method must receive the same number and type of arguments, and have the same return value, as the method specified in the abstract class;
        public override double CalculateSurface()
        {
            if (Width <= 0 || Height <= 0)
                throw new NegativeNumberException();
            return Math.PI * base.Width * base.Height;
        }
    }
}
