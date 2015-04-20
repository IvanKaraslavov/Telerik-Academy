using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

    class PrefixTest
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../result.txt"))
            {
                using (StreamReader reader = new StreamReader("../../test.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                        writer.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("The file is written!");
        }
    }

