using System;

    class PointInACircle
    {
        static void Main()
        {
            //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

            Console.WriteLine("Enter your points:");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            int r = 2;
            bool inside = (x * x) + (y * y) <= (r * r);
            Console.WriteLine("Is the point inside the circle? {0}",inside);
        }
    }

