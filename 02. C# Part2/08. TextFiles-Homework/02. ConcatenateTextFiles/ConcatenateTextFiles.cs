using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstPath = "../../firstTextFile.txt";
        string secondPath = "../../secondTextFile.txt";
        string resultPath = "../../result.txt";
        ReadTheTextFile(firstPath, resultPath);
        ReadTheTextFile(secondPath, resultPath);
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
        using (StreamWriter result = new StreamWriter(resultPath, true))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream)
                { 
                    result.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
    

