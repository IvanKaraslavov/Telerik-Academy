using System;
using System.Numerics;

    class CalculateNKNK
    {
        static void Main()
        {
            //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            //(also known as the number of combinations) is calculated by the following formula: formula 
            //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
            //Try to use only two loops.

            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter k: ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            int subtraction = n - k;
            BigInteger factorialNK = 1;
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
                
            }
            for (int p = 1; p <= subtraction; p++)
            {
                factorialNK *= p;
            }
            result = factorialN / (factorialK * factorialNK);
            Console.WriteLine("Result: {0}",result);
        }
    }

