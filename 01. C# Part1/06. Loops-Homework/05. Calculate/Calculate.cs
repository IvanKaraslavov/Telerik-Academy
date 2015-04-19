using System;

    class Calculate
    {
        static void Main()
        {
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        //Use only one loop. Print the result with 5 digits after the decimal point.

            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter x: ");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            double sum = 1;
            double S = 1;
            for (int i = 1; i <= n; i++)
            {
                
                    factorial *= i;

                    sum *= x;
                    S = S + (factorial / sum);
            }
            
            Console.WriteLine("{0:F5}", S);
        } 
    }

