using System;
using System.Linq;
using System.Text;

//Write a program that reverses the words in given sentence.

    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    sb.Append(words[i] + " ");
                }
                else
                {
                    sb.Append(words[i]);
                }
            }
            char sign = input[input.Length - 1];
            sb.Append(sign);
            sb.ToString();
            Console.WriteLine(sb);
        }
    }

