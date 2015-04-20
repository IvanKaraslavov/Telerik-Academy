using System;
using System.Linq;

//Write a program that reads a string, reverses it and prints the result at the console.

    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string: ");
            string s = Console.ReadLine();
            string reversed = new string(s.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }

