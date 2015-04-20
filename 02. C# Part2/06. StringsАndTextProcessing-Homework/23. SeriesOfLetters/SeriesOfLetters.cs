using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a string from the console and replaces all series of consecutive 
//identical letters with a single one.

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter your text: ");
        string input = Console.ReadLine();
        var letters = input.ToCharArray();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < letters.Length - 1; i++)
        {
            if (letters[i] != letters[i + 1])
            {
                sb.Append(letters[i]);
            }
        }
        char last = input[input.Length - 1];
        sb.Append(last);
        sb.ToString();
        Console.WriteLine(sb);
    }
}

