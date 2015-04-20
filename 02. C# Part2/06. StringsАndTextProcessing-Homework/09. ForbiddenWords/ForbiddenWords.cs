using System;
using System.Linq;
using System.Text.RegularExpressions;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            string[] blackList = { "PHP", "CLR", "Microsoft" };

            string regex = string.Format(@"\b({0})\b", string.Join("|", blackList));

            Console.WriteLine("Result: \n\n{0}\n", Regex.Replace(text, regex, word => new string('*', word.Length)));
            
        }
    }

