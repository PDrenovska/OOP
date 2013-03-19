namespace Shapes
{
    // A class inheriting from base class Shape would have to implement the CalculateSurface method;
    public class Rectangle : Shape
    {
        // A constructor can use the base keyword to call the constructor of a base class;
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {     
            if(Width <= 0 || Height <= 0)
                throw new NegativeNumberException();
            return Width * Height;
        }
    }
}
