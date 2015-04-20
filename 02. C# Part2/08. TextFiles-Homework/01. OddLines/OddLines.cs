using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

    class OddLines
    {
        static void Main()
        {
            const string path = "../../OddLines.txt";
            Console.WriteLine("Print only the odd lines: ");
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                int lineCount = 1;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (lineCount % 2 != 0)
                    {
                        Console.WriteLine(line);
                        
                    }
                    lineCount++;
                }
            }

        }
    }

