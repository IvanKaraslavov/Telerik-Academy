using System;
using System.IO;
using System.Text.RegularExpressions;

//Modify the solution of the previous problem to replace only whole words (not strings).

class ReplaceWholeWord
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
                    writer.WriteLine(Regex.Replace(reader.ReadLine(), @"\bstart\b", "finish"));
                }
            }
        }
    }

}

