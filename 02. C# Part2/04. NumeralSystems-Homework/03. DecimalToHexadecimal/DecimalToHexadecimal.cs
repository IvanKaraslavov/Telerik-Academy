using System;

//Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number:");
        long input = long.Parse(Console.ReadLine());
        string toHexademical = NumberToHexademical(input);
        Console.WriteLine(toHexademical);
    }

    private static string NumberToHexademical(long input)
    {
        string toHexademical = "";
        while (input > 0)
        {
            var digit = input % 16;
            if (digit >= 0 && digit <= 9)
            {
                toHexademical = (char)(digit + '0') + toHexademical;
            }
            else if (digit >= 10 && digit <= 15)
            {
                toHexademical = (char)(digit - 10 + 'A') + toHexademical;
            }
            input = input / 16;
        }
        return toHexademical;
    }
}

