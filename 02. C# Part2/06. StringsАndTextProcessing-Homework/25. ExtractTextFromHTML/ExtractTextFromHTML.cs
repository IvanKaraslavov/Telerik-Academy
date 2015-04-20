using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title (if available), and its body 
//text without the HTML tags.

    class ExtractTextFromHTML
    {
        static void Main()
        {
            string input = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practicaltraining for young people who want to turn into skilful .NET software engineers.</p></body></html>";
            int startText = input.IndexOf("<p>");
            int endText = input.IndexOf("</p>");
            string text = input.Substring(startText + 3, endText - startText - 3);
            string finalText = Regex.Replace(text, @"<a href=""(.*?)"">(.*?)</a>", "$2 ");
            int startTitle = input.IndexOf("<title>");
            int endTitle = input.IndexOf("</title>");
            string title = input.Substring(startTitle + 7, endTitle - startTitle - 7 );
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Text: {0}", finalText);
        }
    }


