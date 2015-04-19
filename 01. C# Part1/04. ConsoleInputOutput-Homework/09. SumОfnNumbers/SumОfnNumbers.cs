using System;

    class SumОfnNumbers
    {
        static void Main()
        {
            //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

            Console.WriteLine("Write how many numbers will you calculate and then write them:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());
                sum = firstNumber + sum;
                
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

