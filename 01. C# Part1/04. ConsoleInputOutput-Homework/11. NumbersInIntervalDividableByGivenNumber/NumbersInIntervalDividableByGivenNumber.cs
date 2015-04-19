using System;

    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p
            //exist between them such that the reminder of the division by 5 is 0.

            Console.WriteLine("Enter start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many numbers: ");
            int p = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                if (i % 5 ==0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }

