using System;

    class RandomizeTheNumbers1ToN
    {
        static void Main()
        {
            //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

            Console.WriteLine("Enter your n:");
            int n = int.Parse(Console.ReadLine());
            Random numbers = new Random();
            for (int p = 1; p <= n; p++)
            {
                Console.Write("{0} ", numbers.Next(1, n + 1));
            }
        }
    }

