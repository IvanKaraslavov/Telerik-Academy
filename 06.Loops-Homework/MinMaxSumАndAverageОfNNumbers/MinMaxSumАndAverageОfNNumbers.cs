using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal 
            //number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

            Console.WriteLine("Please enter how many number you want and then enter them: ");
            int N = int.Parse(Console.ReadLine());
            int? min = null;
            int? max = null;
            int sum = 0;
            double avrg;
            for (int i = 1; i <= N; i++)
            {
                int p = int.Parse(Console.ReadLine());
                sum += p;
                if (max == null || p >= max) { max = p; }
                if (min == null || p <= min) { min = p; }
            }
            avrg = (double)sum / (double)N;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:f2}", min, max, sum, avrg);
            Console.ReadLine();
        }
    }
