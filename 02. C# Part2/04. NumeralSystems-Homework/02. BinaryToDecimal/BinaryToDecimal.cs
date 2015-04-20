using System;

//Write a program to convert binary numbers to their decimal representation.

    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter a binary number: ");
            string input = Console.ReadLine();
            long toDecimal = NumberToDecimal(input);
            Console.WriteLine(toDecimal);
        }

        private static long NumberToDecimal(string input)
        {
            long decimalNumber = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                decimalNumber += digit * (long)Math.Pow(2, input.Length - i - 1);
            }
            return decimalNumber;
        }
    }

