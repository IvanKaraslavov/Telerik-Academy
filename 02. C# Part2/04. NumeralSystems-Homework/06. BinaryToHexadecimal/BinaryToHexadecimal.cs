using System;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter a binary number: ");
            string binaryNumber = Console.ReadLine();
            string hexNumber = "";
            long decimalNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i] - '0';
                decimalNumber += digit * (long)Math.Pow(2, binaryNumber.Length - i - 1);
            }
            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hexNumber = (char)(digit + '0') + hexNumber;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hexNumber = (char)(digit - 10 + 'A') + hexNumber;
                }
                decimalNumber = decimalNumber / 16;
            }
            Console.WriteLine(hexNumber);
        }
    }

