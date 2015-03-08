using System;

    class Rectangles
    {
        static void Main()
        {
            //Write an expression that calculates rectangle’s perimeter and area by given width and height.

            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (2 * width) + (2 * height);
            double area = width * height;
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            Console.WriteLine("The area of the rectangle is: {0}", area);
        }
    }

