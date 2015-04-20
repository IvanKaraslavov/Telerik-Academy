using System;
using System.Linq;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Please write a string with max length 20: ");
            string input = Console.ReadLine();
            if (input.Length <= 20)
            {
                string newString = new string('*', 20 - input.Length);
                Console.WriteLine(input + newString );
            }
            else
            {
                Console.WriteLine("The length of your string must be max 20.");
            }
        }
    }

