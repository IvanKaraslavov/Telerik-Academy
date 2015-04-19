using System;

class TrailingZeroesInN
{
    static void Main()
    {
                //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
                //Your program should work well for very big numbers, e.g. n=100000.

        Console.WriteLine("Enter your number:");
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        int divider = 5;
        while (n / divider >= 1)
        {
            counter += n / divider;
            divider *= 5;
        }
        Console.WriteLine("{1} trailing zeros", counter);
    }
}