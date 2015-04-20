using System;
using System.Collections.Generic;
using System.Linq;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {".NET", "platform for applications from Microsoft"},
                {"CLR", "managed execution environment for .NET"},
			{"NAMESPACE", "hierarchical organization of classes"}
            };
        Console.WriteLine("Please enter a word: ");
        string input = Console.ReadLine().ToUpper();
        if (dictionary.ContainsKey(input))
        {
            Console.WriteLine("The explanation of the word is: {0}.", dictionary[input]);
        }
        else
        {
            Console.WriteLine("There is no such word in the dictionary.");
        }
    }
}

