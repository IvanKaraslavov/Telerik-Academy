using System;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

    class CompareTextFiles
    {
        static int sameLinesCount = 0;
        static int diffLinesCount = 0;

        static void Main()
        {
            string firstPath = "../../firstTextFile.txt";
            string secondtPath = "../../secondTextFile.txt";

            CompareFiles(firstPath, secondtPath);

            Console.WriteLine("Same lines: {0}", sameLinesCount);
            Console.WriteLine("Different lines: {0}\n", diffLinesCount);
        }

        static void CompareFiles(string pathText1, string pathText2)
        {
            using (StreamReader reader1 = new StreamReader(pathText1))
            {
                using (StreamReader reader2 = new StreamReader(pathText2))
                {
                    while (!reader1.EndOfStream || !reader2.EndOfStream)
                    {
                        string line1 = reader1.ReadLine();
                        string line2 = reader2.ReadLine();

                        if (String.Compare(line1, line2, StringComparison.Ordinal) == 0) sameLinesCount++;
                        else diffLinesCount++;
                    }
                }
            }
        }
    }

