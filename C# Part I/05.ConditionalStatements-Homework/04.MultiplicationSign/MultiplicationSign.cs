using System;

    class MultiplicationSign
    {
        static void Main()
        {
            //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

            Console.WriteLine("Write a, b and c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a * b * c < 0)
            {

                Console.WriteLine("Result: -");
            }
            else if (a * b * c > 0)
            {
                Console.WriteLine("Result: +");

            }
            else
            {
                Console.WriteLine("Result: 0");

            }
        }
    }

