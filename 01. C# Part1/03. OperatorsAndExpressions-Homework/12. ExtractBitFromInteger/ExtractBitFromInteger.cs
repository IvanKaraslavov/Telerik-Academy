using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.

            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(bit);
        }
    }

