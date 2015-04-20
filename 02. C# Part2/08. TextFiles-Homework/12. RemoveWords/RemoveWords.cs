using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

class RemoveWords
{
    static readonly List<string> blackList = new List<string>();
    static void Main()
    {
        try
        {
            const string firstPath = "../../test.txt";
            const string secondPath = "../../words.txt";
            const string result = "../../output.txt";

            GetBlackWords(secondPath);
            ExtractTextWithoutTags(firstPath, result);
        }
        catch (DriveNotFoundException driveError)
        {
            PrintErrorMessage(driveError);
        }
        catch (DirectoryNotFoundException directoryError)
        {
            PrintErrorMessage(directoryError);
        }
        catch (EndOfStreamException eose)
        {
            PrintErrorMessage(eose);
        }
        catch (FileNotFoundException fnfe)
        {
            PrintErrorMessage(fnfe);
        }
        catch (FileLoadException fle)
        {
            PrintErrorMessage(fle);
        }
        catch (PathTooLongException ptle)
        {
            PrintErrorMessage(ptle);
        }
    }

    static void PrintErrorMessage(Exception error)
    {
        Console.Error.WriteLine("-> Error! {0}\n", error.Message);
    }

    static void GetBlackWords(string pathBlackList)
    {
        using (StreamReader reader = new StreamReader(pathBlackList))
        {
            while (!reader.EndOfStream)
            {
                string[] tokens = reader.ReadLine().Split(new[] { ' ', ',', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string t in tokens)
                {
                    if (!blackList.Contains(t))
                    {
                        blackList.Add(t);
                    }
                }
            }
        }
    }

    static void ExtractTextWithoutTags(string pathText, string pathResult)
    {
        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    line = blackList.Aggregate(line, (current, t) => Regex.Replace(current, "\\b" + t + "\\b", String.Empty));

                    result.WriteLine(line);
                }
            }
        }
    }
}

