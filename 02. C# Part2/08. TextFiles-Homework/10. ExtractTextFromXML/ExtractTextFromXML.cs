using System;
using System.IO;

//Write a program that extracts from given XML file all the text without the tags.

class ExtractTextFromXML
{

    static void Main()
    {


        using (StreamReader reader = new StreamReader("../../test.xml"))
        {
            string line;
            string words = string.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        while (line[i] != '>')
                        {
                            i++;
                            continue;
                        }
                    }
                    else
                    {
                        words += line[i];
                        if (line[i + 1] == '<')
                        {
                            Console.WriteLine(words);
                            words = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
    

