﻿using System;

    class CalculateNK
    {
        static void Main()
        {
            //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            //Use only one loop.
                        
            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter k: ");
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
            result = factorialN / factorialK;
            Console.WriteLine("Result: {0}",result);
        }
    }

