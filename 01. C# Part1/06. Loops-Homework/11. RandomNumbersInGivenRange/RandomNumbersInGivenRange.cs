using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            //Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers 
            //in the range [min...max].

            Console.WriteLine("Enter your n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your min:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your max:");
            int max = int.Parse(Console.ReadLine());
            Random numbers = new Random();
             for (int p = 1; p <= n; p++)
                {
                    Console.Write("{0} ",numbers.Next(min, max + 1));
                }
            
        }
    }

