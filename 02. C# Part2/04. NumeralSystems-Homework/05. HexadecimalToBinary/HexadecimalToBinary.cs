using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexToBin
{
    static void Main()
    {
        Console.WriteLine("Please enter a hexadecimal number: ");
        string inputHexRepresentation = Console.ReadLine();

        string binaryRepresentation = "";

        for (int i = inputHexRepresentation.Length - 1; i >= 0; i--)
        {
            char hexadecimalDigit = inputHexRepresentation[i];
            byte decimalRepresentation = 0;
            if (char.IsNumber(hexadecimalDigit))
            {
                decimalRepresentation = (byte)(hexadecimalDigit - '0');
            }
            else
            {
                switch (hexadecimalDigit)
                {
                    case 'A':
                        decimalRepresentation = 10;
                        break;
                    case 'B':
                        decimalRepresentation = 11;
                        break;
                    case 'C':
                        decimalRepresentation = 12;
                        break;
                    case 'D':
                        decimalRepresentation = 13;
                        break;
                    case 'E':
                        decimalRepresentation = 14;
                        break;
                    case 'F':
                        decimalRepresentation = 15;
                        break;
                }
            }

            while (decimalRepresentation != 0)
            {
                byte remainder = (byte)(decimalRepresentation % 2);
                binaryRepresentation = remainder + binaryRepresentation;
                decimalRepresentation = (byte)(decimalRepresentation / 2);
            }
        }
        Console.WriteLine(binaryRepresentation);
    }
}
