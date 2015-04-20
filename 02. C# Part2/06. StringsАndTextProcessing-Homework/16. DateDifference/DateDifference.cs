using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

//Write a program that reads two dates in the format: day.month.year and calculates the number 
//of days between them.

    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter the first date (in format day.month.year): ");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Enter the second date (in format day.month.year): ");
            string secondDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(firstDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(secondDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("{0} days", Math.Abs((end - start).TotalDays));
        }
    }

