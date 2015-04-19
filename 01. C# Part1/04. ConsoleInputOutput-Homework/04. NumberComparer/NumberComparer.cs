using System;

    class NumberComparer
    {
        static void Main()
        {
                //Write a program that gets two numbers from the console and prints the greater of them.
                //Try to implement this without if statements.

            Console.WriteLine("Write a and b:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            object result;
            result = (a > b ? a : b);
            Console.WriteLine("The greater number is: {0}", result);
        }
    }

