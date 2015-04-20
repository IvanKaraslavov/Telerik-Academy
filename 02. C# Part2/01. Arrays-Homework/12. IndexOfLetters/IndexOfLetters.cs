using System;

    class IndexOfLetters
    {
        static void Main()
        {
            //Write a program that creates an array containing all letters from the alphabet (A-Z).
            //Read a word from the console and print the index of each of its letters in the array.

            Console.WriteLine("Enter your word: ");
            string word = Console.ReadLine().ToUpper();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} [{1}]", word[i], j);
                    }
                }
            }
        }
    }