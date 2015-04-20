using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a list of words, separated by spaces and prints the list in 
//an alphabetical order.

    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Write your words: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { " ", ";", ",", ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }

