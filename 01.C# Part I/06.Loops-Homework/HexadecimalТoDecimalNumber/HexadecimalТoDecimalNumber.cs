using System;


    class HexadecimalТoDecimalNumber
    {
        static void Main(string[] args)
        {
                //Using loops write a program that converts a hexadecimal integer number to its decimal form.
                //The input is entered as string. The output should be a variable of type long.
                //Do not use the built-in .NET functionality.

            Console.WriteLine("Write your hexadecimal number: ");
            string n = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(n, 16));
        }
    }

