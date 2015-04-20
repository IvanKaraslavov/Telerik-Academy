using System;
using System.Linq;

//You are given a text. Write a program that changes the text in all regions surrounded
//by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

    class ParseTags
    {
        static void Main()
        {
            Console.WriteLine("Please write a string: ");
            string input = Console.ReadLine();
            string text = UpperLetters(input);
            Console.WriteLine(text);
        }

        private static string UpperLetters(string input)
        {
            
            while (input.IndexOf("<upcase>") != -1)
            {
                int start = input.IndexOf("<upcase>");
                int end = input.IndexOf("</upcase>");
                string cut = input.Substring(start + "<upcase>".Length, end - start - "<upcase>".Length);
                input = input.Replace("<upcase>" + cut + "</upcase>", cut.ToUpper());
            }
            return input;
        }
    }

