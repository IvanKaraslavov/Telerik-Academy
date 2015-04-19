using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
                //Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like
                //in the examples below. Use two nested loops.

            Console.WriteLine("Please enter your number: ");
            int n = int.Parse(Console.ReadLine());
            int howMany = 0;
            int result = n + howMany;
            for (int row = 1; row <= n; row++)
            {
                
                Console.WriteLine();
                for (int i = row; i <= n + howMany ; i++)
                {
                     Console.Write("{0} ", i);      
                }
                howMany++;
            }
        }
    }

