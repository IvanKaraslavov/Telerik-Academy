using System;

    class SumOf3Numbers
    {
        static void Main()
        {
            //Write a program that reads 3 real numbers from the console and prints their sum.

            Console.WriteLine("Enter your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number: ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine("The sum of the three numbers is: {0} ", sum);

        }
    }

