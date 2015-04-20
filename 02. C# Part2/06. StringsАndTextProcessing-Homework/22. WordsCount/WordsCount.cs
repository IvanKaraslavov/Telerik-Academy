using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a string from the console and lists all different words 
//in the string along with information how many times each word is found.

    class WordsCount
    {
        static void Main()
        {
            Console.WriteLine("Write your text: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { " ", ";", ",", ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries);
            var numberWord = words.ToArray().GroupBy(a => a);
            foreach (var word in numberWord)
            {
                Console.WriteLine("Word [{0}]: {1} times", word.Key, word.Count());
            }
        }
    }

