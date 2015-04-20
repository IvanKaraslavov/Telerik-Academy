using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that replaces in a HTML document given as string all the tags 
//<a href="…">…</a> with corresponding tags [URL=…]…/URL].

    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("Write your string: ");
            string text = Console.ReadLine();
            Console.WriteLine(Regex.Replace(text, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
        }
    }

