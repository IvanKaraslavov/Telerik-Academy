namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesTest
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] {
                new Triangle(3.43, 23),
                new Rectangle(5.54, 12),
                new Circle(5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
