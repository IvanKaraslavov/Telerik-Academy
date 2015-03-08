using System;

    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
                    //Write a program that enters 3 real numbers and prints them sorted in descending order.
                    //Use nested if statements.

            Console.WriteLine("Write your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your third number: ");
            double c = double.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {

                if (b >= c)
                {
                    Console.WriteLine("Result: {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2}", a, c, b);
                }
            }
            else if (b >= c && b >= a)
            {
                if (a >= c)
                {
                    Console.WriteLine("Result: {0} {1} {2}", b, a, c);

                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2}", b, c, a);
                }
            }
            else if (c >= b && c >= a)
            {
                if (a >= b)
                {
                    Console.WriteLine("Result: {0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2}", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("Invalid numbers.");
            }
        }
    }


