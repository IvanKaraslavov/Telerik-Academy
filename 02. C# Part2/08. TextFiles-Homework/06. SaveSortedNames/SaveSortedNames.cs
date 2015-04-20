using System;
using System.IO;
using System.Collections.Generic;

//Write a program that reads a text file containing a list of strings, sorts them and saves 
//them to another text file.

    class SaveSortedNames
    {
        static List<string> names = new List<string>();
        static void Main()
        {
            string firstPath = "../../namesFile.txt";
            string resultPath = "../../result.txt";

            SeparateStringsFromNamesFile(firstPath);
            names.Sort();
            PrintNamesToTextFile(resultPath);
            PrintItOnTheConsole(resultPath);
        }

        private static void PrintItOnTheConsole(string resultPath)
        {
            using (StreamReader readerNames = new StreamReader(resultPath))
            {
                while (!readerNames.EndOfStream)
                {
                    Console.WriteLine(readerNames.ReadLine());
                }
            }
        }

        private static void PrintNamesToTextFile(string resultPath)
        {
            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                foreach (var name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }

        private static void SeparateStringsFromNamesFile(string firstPath)
        {
            using (StreamReader reader = new StreamReader(firstPath))
            {
                while (!reader.EndOfStream)
                {
                    string[] findNames = reader.ReadLine().Split(new[] { ' ', ',', '\n' },
					StringSplitOptions.RemoveEmptyEntries);
                    foreach (var name in findNames)
                    {
                        names.Add(name);
                    }
                }
            }
        }
    }

