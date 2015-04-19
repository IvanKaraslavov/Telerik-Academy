using System;

    class BitsExchange
    {
        static void Main()
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.WriteLine("Enter a number:");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("The binary represantation of {0} is \n{1}", n, Convert.ToString(n,2).PadLeft(32, '0'));
            uint firstMask = 56u;
            uint lastMask = 117440512u;
            uint first3Digits = n & firstMask;
            uint last3Digits = n & lastMask;
            first3Digits = first3Digits << 21;
            last3Digits = last3Digits >> 21;
            n = n & ~(firstMask);
            n = n & ~(lastMask);
            n = n | first3Digits;
            n = n | last3Digits;
            Console.WriteLine("Binary result is:\n{0}\nResult: {1}", Convert.ToString(n, 2).PadLeft(32, '0'), n);

        }
    }

