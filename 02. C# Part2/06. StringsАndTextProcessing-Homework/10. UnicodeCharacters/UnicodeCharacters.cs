using System;
using System.Linq;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Please write a string: ");
            string input = Console.ReadLine();
            char[] symbols = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char c in symbols)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            sb.ToString();
            Console.WriteLine(sb);
        }
    }

