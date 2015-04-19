
using System;

    class QuadraticEquation
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and 
            //solves it (prints its real roots).

            Console.WriteLine("Write your a,b and c for the quadric equation (ax2 + bx + c): ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("X1 = {0}", x1);
            Console.WriteLine("X2 = {0}", x2);
        }
    }

