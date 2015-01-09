using System;

       //Write a program to read your birthday from the console and print how old 
       //you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    static void Main()
        {

            Console.WriteLine("Write your birthday in format: yyyy.m.d (e.g. 2003.8.12)");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = DateTime.Now.Year - birthday.Year;
            if ((birthday.Month <= today.Month && birthday.Day <= today.Day) ^ (birthday.Month < today.Month && birthday.Day > today.Day))
            {
                Console.WriteLine("You are {0} years old.", age);
                Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
            }
            else
            {
                Console.WriteLine("You are {0} years old.", age - 1);
                Console.WriteLine("After 10 years you will be {0} years old.", age + 9);
            }
        }
}
