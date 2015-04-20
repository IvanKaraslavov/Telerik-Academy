using System;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

 class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Please write a year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime newYear = new DateTime(year, 1, 1);
            bool isLeap = DateTime.IsLeapYear(newYear.Year);
            Console.WriteLine("Is the year leap? {0}", isLeap);
        }
    }

