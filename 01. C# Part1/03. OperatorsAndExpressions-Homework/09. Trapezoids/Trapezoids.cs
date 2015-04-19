using System;

    class Trapezoids
    {
        static void Main()
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.

            Console.WriteLine("Enter the first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the h:");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b)/2) * h;
            Console.WriteLine("The area is: {0}", area);
        }
    }

