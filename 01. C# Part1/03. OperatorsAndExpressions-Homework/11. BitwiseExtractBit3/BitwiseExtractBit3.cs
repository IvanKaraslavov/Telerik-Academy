﻿using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
                //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
                //The bits are counted from right to left, starting from bit #0.
                //The result of the expression should be either 1 or 0.

            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int nAndMask = n & mask;
            int bit = nAndMask >> 3;
            Console.WriteLine(bit);
        }
    }

