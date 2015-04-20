using System;

//Write a program to convert hexadecimal numbers to their decimal representation.

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter a hexademical number: ");
            string input = Console.ReadLine();
            long toDecimal = NumberToDecimal(input);
            Console.WriteLine(toDecimal);
        }

        private static long NumberToDecimal(string input)
        {
            long decimalNumber = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    long digit = input[i] - '0';
                    decimalNumber += digit * (long)Math.Pow(16, input.Length - i - 1);
                }
                else if (input[i] >= 'A' && input[i] <= 'F')
                {
                    long digit = input[i] - 'A' + 10;
                    decimalNumber += digit * (long)Math.Pow(16, input.Length - i - 1);
                }
            }
            return decimalNumber;
        }
    }

