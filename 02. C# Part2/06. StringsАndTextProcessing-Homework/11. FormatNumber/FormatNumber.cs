using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number,
//percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            string decimalInput = string.Format("{0:D}", value);
            string hexInput = string.Format("{0:X}", value);
            string percentage = string.Format("{0:P}", value);
            string scientificNotation = string.Format("{0:E}", value);
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}", decimalInput, hexInput, percentage, scientificNotation);
        }
    }
}
