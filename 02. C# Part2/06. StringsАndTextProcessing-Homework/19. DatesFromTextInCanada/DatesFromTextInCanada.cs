using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.WriteLine("Write your text: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
            string[] dates = Array.FindAll(words, IsValidDate);
            foreach (var date in dates)
            {
                Console.WriteLine(date);
            }
        }

        private static bool IsValidDate(string date)
        {
            const string pattern = @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}";
            return new Regex(pattern).IsMatch(date.ToString(CultureInfo.GetCultureInfo("en-CA")));

        }
    }

