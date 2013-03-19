namespace Shapes
{
    // Abstract class cannot be instantiated, and is frequently either partially implemented, or not at all implemented;
    public abstract class Shape
    {
        protected double Width;
        protected double Height;

        // An abstract method is implicitly a virtual method;
        // Because an abstract method declaration provides no actual implementation, there is no method body;
        // The implementation is provided by an overriding method, which is a member of a non-abstract class;
        // It is an error to use the static or virtual modifiers in an abstract method declaration;
        public abstract double CalculateSurface();

        // We can prevent a class from being instantiated by making the constructor private or protected:
        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
