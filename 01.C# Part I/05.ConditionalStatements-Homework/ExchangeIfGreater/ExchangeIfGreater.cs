using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            //Write an if-statement that takes two double variables a and b and exchanges their values
            //if the first one is greater than the second one. As a result print the values a and b, separated by a space.

            Console.WriteLine("Write your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your second number: ");
            double b = double.Parse(Console.ReadLine());
            double result = a;
            double resultSecond = b;

            if (b > a)
            {
                Console.WriteLine("Result: {0} {1}", result, resultSecond);


            }
            else
            {
                Console.WriteLine("Result: {0} {1} ", resultSecond, result);
            }
        }
    }

