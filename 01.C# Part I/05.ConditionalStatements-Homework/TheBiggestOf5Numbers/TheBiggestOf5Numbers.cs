using System;

    class TheBiggestOf5Numbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of five numbers by using only five if statements.

            Console.WriteLine("Write your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your fourth number: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your fifth number: ");
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("The biggest number is: {0}", d);
            }
            else if (e > a && e > b && e > d && e > c)
            {
                Console.WriteLine("The biggest number is: {0}", e);
            }
            else
            {
                Console.WriteLine("There are two or more equal numbers.");
            }
        }
    }
