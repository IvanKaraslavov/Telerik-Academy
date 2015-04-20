using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

    class Palindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your text: ");
            string input = Console.ReadLine().ToUpper();
            string[] words = input.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse()))
                {
                    Console.WriteLine(word.ToLower());
                }
            }

        }
    }

