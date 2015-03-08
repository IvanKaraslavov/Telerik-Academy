using System;

    class PointInsideАCircleAndOutsideОfАRectangle
    {
        static void Main()
        {
            //Write an expression that checks for given point (x, y) if it is within 
            //the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

            Console.WriteLine("Enter your points:");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (r * r);
            bool isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
            bool result = isInCircle && !isInRectangle;
            Console.WriteLine(result);
        }
    }

