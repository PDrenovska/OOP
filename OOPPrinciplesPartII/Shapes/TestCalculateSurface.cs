namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class TestCalculateSurface
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            Triangle triangle = new Triangle(5, 2);
            Rectangle rect = new Rectangle(10, 5);
            Circle circle = new Circle(4);

            shapes.Add(triangle);
            shapes.Add(rect);
            shapes.Add(circle);

            Console.WriteLine("Triangle surface is : {0:F2}", triangle.CalculateSurface());
            Console.WriteLine("Rectangle surface is : {0:F2}", rect.CalculateSurface());
            Console.WriteLine("Circle surface is : {0:F2}", circle.CalculateSurface());

            Shape[] shapesArray = new Shape[] {
                                           new Rectangle(3, 10),
                                           new Circle(5)
                                       };
            foreach (var shape in shapesArray)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
