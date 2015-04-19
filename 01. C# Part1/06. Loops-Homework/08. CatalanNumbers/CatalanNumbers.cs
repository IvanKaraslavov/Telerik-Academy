using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
                //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
                //Write a program to calculate the nth Catalan number by given n (1 < n < 100).

        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger multiplication = 2 * n;
        BigInteger addition = n + 1;

        if (n == 0)
        {
            Console.WriteLine(1);
        }
        else
        {

        
        for (int i = 1; i <= n || i < n + 1; i++)
        {
            if (i <= n)
            {
                nFactorial *= i;
            }
            if (i < n + 1)
            {
                addition *= i;
            }
        }

        for (int d = 1; d < 2 * n; d++)
        {
            multiplication *= d;
        }
        
        Console.WriteLine("Result: {0}",multiplication / (addition * nFactorial));
    }
    }
}
