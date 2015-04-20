using System;

            //Write a program to calculate n! for each n in the range [1..100].

    class NFactorial
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = NArray(n);
            int nFactorial = Factorial(arr);
            Console.WriteLine("!{0} -> {1}", n, nFactorial);
        }

        private static int Factorial(int[] arr)
        {
            int result = 1;
            for (int i = 1; i <= arr.Length; i++)
            {
                result *= i;
            }
            return result;
        }

        private static int[] NArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 1; i <= arr.Length; i++)
            {
                arr[i - 1] = i;
            }
            return arr;
        }

    }

