using System;
using System.Linq;
using System.Text;

//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found.

    class LettersCount
    {
        static void Main()
        {
            Console.WriteLine("Write your text: ");
            string input = Console.ReadLine();
            var letters = input.ToCharArray().GroupBy(a => a);
            foreach (var letter in letters)
            {
                Console.WriteLine("Letter [{0}]: {1} times", letter.Key, letter.Count());
            }
        }
    }

