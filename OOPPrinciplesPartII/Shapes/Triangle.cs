namespace Shapes
{
    // A class inheriting from base class Shape would have to implement the CalculateSurface method;
    public class Triangle : Shape
    {
        // A constructor can use the base keyword to call the constructor of a base class;
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            // We can use our custom exception like most other exceptions; 
            // We can throw an instance of NegativeNumberException and pass a message which describes the occurred error;
            if (Width <= 0 || Height <= 0)
                throw new NegativeNumberException();
            return (Width * Height) / 2;
        }
    }
}
