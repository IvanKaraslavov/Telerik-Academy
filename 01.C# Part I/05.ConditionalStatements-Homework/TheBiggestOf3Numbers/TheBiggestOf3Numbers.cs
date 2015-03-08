using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of three numbers.

            Console.WriteLine("Write your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your third number: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
            else
            {
                Console.WriteLine("There are two or three equal numbers.");
            }
        }
    }


