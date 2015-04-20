using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

    class CountWords
    {
        static readonly Dictionary<string, int> countWords = new Dictionary<string, int>();
        static void Main()
        {
            try
            {
                const string pathText = "../../test.txt";
                const string pathWords = "../../words.txt";
                const string pathResult = "../../result.txt";

                GetSearchedWords(pathWords);
                GetWordOccurs(pathText, pathResult);
                Console.WriteLine("The file is written!");
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
            catch (InvalidOperationException ioe)
            {
                PrintErrorMessage(ioe);
            }
        }

        static void PrintErrorMessage(Exception error)
        {
            Console.Error.WriteLine("-> Error! {0}\n", error.Message);
        }

        static void GetSearchedWords(string pathSearchedWords)
        {
            using (StreamReader reader = new StreamReader(pathSearchedWords))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(new char[] { ' ', ',', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (string t in tokens)
                    {
                        if (!countWords.ContainsKey(t))
                        {
                            countWords.Add(t, 0);
                        }
                    }
                }
            }
        }

        static void GetWordOccurs(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    var allContent = reader.ReadToEnd();

                    for (int i = 0; i < countWords.Count; i++)
                    {
                        KeyValuePair<string, int> word = countWords.ElementAt(i);
                        int index = allContent.IndexOf(word.Key, StringComparison.Ordinal);

                        while (index != -1)
                        {
                            countWords[word.Key]++;
                            index = allContent.IndexOf(word.Key, index + 1, StringComparison.Ordinal);
                        }
                    }
                }

                WriteWordOccursToFile(result);
            }
        }

        static void WriteWordOccursToFile(StreamWriter result)
        {
            foreach (KeyValuePair<string, int> word in countWords.OrderByDescending(key => key.Value))
                result.WriteLine(word.Key + " -> " + word.Value + " time(s).");
        }
    }


