using System;

//Write a program to convert decimal numbers to their binary representation.

    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please enter a decimal number: ");
            long input = long.Parse(Console.ReadLine());
            string binary = NumberToBinary(input);
            Console.WriteLine(binary);
        }

        static string NumberToBinary(long input)
        {
            string toBinary = "";
            while (input > 0)
            {
                var digit = input % 2;
                toBinary = digit + toBinary;
                input = input / 2;
            }
            return toBinary;
        }
    }

