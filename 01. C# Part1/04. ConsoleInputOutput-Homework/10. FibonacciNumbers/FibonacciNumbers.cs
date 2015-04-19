using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            //Write a program that reads a number n and prints on the console the first n members of 
            //the Fibonacci sequence (at a single line, separated by comma and
            //space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            int firstFibonacci = 0;
            int secondFibonacci = 1 ;
            int thirdFibonacci = 0;
            if( n == 0 || n ==1)
            {
                Console.Write("{0}", firstFibonacci);
            }
            else
            {
                Console.Write("{0}, {1}", firstFibonacci, secondFibonacci);
            }
            
            for (int i = 1; i <= n -2; i++)
            {

                thirdFibonacci = firstFibonacci + secondFibonacci;
                firstFibonacci = secondFibonacci;
                secondFibonacci = thirdFibonacci;
                Console.Write(", {0}", thirdFibonacci);
            }
        }
    }

