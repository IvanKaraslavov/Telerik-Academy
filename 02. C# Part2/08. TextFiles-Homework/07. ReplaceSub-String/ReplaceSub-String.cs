using System;
using System.IO;

//Write a program that replaces all occurrences of the sub-string start with the sub-string 
//finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

    class Program
    {
        static void Main()
        {
            string firstPath = "../../textFile.txt";
            string resultPath = "../../result.txt";

            ReplaceTheWords(firstPath, resultPath);
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
        private static void ReplaceTheWords(string firstPath, string resultPath)
        {
            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                using (StreamReader reader = new StreamReader(firstPath))
                {
                    while (!reader.EndOfStream)
                    {
                        writer.WriteLine(reader.ReadLine().Replace("start", "finish"));
                    }
                }
            }
        }
    }

