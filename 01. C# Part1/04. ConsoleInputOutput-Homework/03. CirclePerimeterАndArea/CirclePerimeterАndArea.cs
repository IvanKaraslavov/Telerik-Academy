using System;

    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
            //with 2 digits after the decimal point.

            Console.WriteLine("Write the r of the circle: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("The area of the circle is: {0:0.00}", area);
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("The perimeter of the circle is: {0:0.00}", perimeter);
        }
    }

