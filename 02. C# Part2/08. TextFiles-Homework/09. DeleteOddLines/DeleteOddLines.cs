using System;
using System.IO;
using System.Collections.Generic;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

    class DeleteOddLines
    {
        //static List<string> onlyEvenLines = new List<string>();
        //static void Main()
        //{
        //    string firstPath = "../../textFile.txt";
        //    string resultPath = "../../result.txt";
        //    ReadOnlyTheLines(firstPath);
        //    WriteOnlyTheLines(resultPath);
        //    PrintItOnTheConsole(resultPath);

        //}

        //private static void PrintItOnTheConsole(string resultPath)
        //{
        //    using (StreamReader reader = new StreamReader(resultPath))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            Console.WriteLine(reader.ReadLine());
        //        }
        //    }
        //}

        //private static void WriteOnlyTheLines(string resultPath)
        //{
        //    using (StreamWriter writer = new StreamWriter(resultPath))
        //    {
        //        foreach (var line in onlyEvenLines)
        //        {
        //            writer.WriteLine(line);
        //        }
        //    }
        //}

        //private static void ReadOnlyTheLines(string firstPath)
        //{
        //    using (StreamReader reader = new StreamReader(firstPath))
        //    {
        //        int lineCount = 1;
        //        while (!reader.EndOfStream)
        //        {
        //            string line = reader.ReadLine();
        //            if (lineCount % 2 == 0)
        //            {
        //                onlyEvenLines.Add(line);
        //            }
        //            lineCount++;
        //        }
        //    }
        //}
        static void Main()
        {
            List<string> playerNameAndScore = new List<string>();
            //List<string> words = new List<string>();
            List<string> playerName = new List<string>();
            
            using (StreamReader reader = new StreamReader("../../file.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    playerNameAndScore.Add(line); //Add name and score to the list
                }
            }
            string[] words = new string[playerNameAndScore.Count];
            //for (int i = 0; i < playerNameAndScore.Count; i++)
            //{
            //    words = playerNameAndScore[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    Array.Reverse(words);
            //    playerNameAndScore[i].

            //}
            playerNameAndScore.Sort();
            using (var writer = new StreamWriter("../../score.txt"))
            {
                for (int i = playerNameAndScore.Count - 1; i >= 0; i--)
                {
                    writer.WriteLine(playerNameAndScore[i]);
                }
            }
        }
    }

