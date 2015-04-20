using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

    class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Please enter a valid integer: ");
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                double result = Math.Sqrt(number);
                Console.WriteLine("The Square Root of {0} is {1:F2}", number, result);
            }
            catch 
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }

