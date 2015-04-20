using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class Program
{
    static void Main()
    {
        string firstPath = "../../firstTextFile.txt";
        string resultPath = "../../result.txt";
        
        ReadTheTextFile(firstPath, resultPath);
        PrintItOnTheConsole(resultPath);
    }

    private static void PrintItOnTheConsole(string resultPath)
    {
        using (StreamReader reader = new StreamReader(resultPath))
        {
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }

    private static void ReadTheTextFile(string pathText, string resultPath)
    {
        int lineCounter = 0;
        using (StreamWriter result = new StreamWriter(resultPath, true))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {

                while (!reader.EndOfStream)
                {
                    result.WriteLine("Line number {0}. {1}", lineCounter, reader.ReadLine());
                    lineCounter++;
                }

            }
        }

    }
}
        
    

