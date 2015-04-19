using System;

    class CheckАBitАtGivenPosition
    {
        static void Main()
        {
            //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
            //in given integer number n, has value of 1.

            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            bool isOne = bit == 1;
            Console.WriteLine(isOne);
        }
    }

