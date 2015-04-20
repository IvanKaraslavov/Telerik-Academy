using System;
using System.Linq;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.

class ExtractSentences
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write the text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter the word: ");
        string word = Console.ReadLine();
        string[] sentences = text.Split(new[] { '.' });
        for (int i = 0; i < sentences.Length; i++)
        {
            if (FindTheWord(sentences, word, i))
            {
                Console.Write(sentences[i] + ". ");
            }
        }
        Console.WriteLine();

    }

    private static bool FindTheWord(string[] sentences, string word, int i)
    {
        return Regex.Matches(sentences[i], string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count != 0;

    }
}
    

