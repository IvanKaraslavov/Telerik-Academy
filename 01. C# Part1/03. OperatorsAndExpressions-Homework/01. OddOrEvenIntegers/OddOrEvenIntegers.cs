using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
               //Write an expression that checks if given integer is odd or even.

            Console.Write("Please write a number:");
            int n = int.Parse(Console.ReadLine());
            bool equal = n % 2 != 0;
            Console.WriteLine(equal);
           
        }
    }

