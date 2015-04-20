using System;

        //Write a method GetMax() with two parameters that returns the larger of two integers.
        //Write a program that reads 3 integers from the console and prints the largest of them 
        //using the method GetMax().

    class GetLargestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int m = int.Parse(Console.ReadLine());
            GetMax(n,m);
        }

        private static void GetMax(int n, int m)
        {
            if (n > m)
            {
                Console.WriteLine("The bigger number is {0}", n);
            }
            else if (n < m)
            {
                Console.WriteLine("The bigger number is {0}", m);
            }
            else
            {
                Console.WriteLine("The numbers are equal. ");
            }
        }
    }

