using System;

class CalculateGCD
{
    static void Main()
    {
                //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
                //Use the Euclidean algorithm (find it in Internet).

        Console.WriteLine("Enter your first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second number:");
        int b = int.Parse(Console.ReadLine());
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        Console.WriteLine(Math.Max(a, b));
        
    }
}
