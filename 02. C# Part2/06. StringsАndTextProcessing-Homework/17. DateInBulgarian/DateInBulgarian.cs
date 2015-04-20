using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

//Write a program that reads a date and time given in the format: day.month.year 
//hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format)
//along with the day of week in Bulgarian.

    class DateInBulgarian
    {
        static void Main()
        {
            var culture = CultureInfo.CreateSpecificCulture("bg-BG");
            
            Console.WriteLine("Please enter a date and time (given in the format: day.month.year hour:minute:second) :");
            string input = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(input).AddHours(6).AddMinutes(30);
            Console.WriteLine("{0} {1}", dateTime.ToString("dddd", new CultureInfo("bg-BG")), dateTime);

        }
    }

