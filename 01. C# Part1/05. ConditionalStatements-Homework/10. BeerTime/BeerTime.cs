
using System;

    class BeerTime
    {
        static void Main()
        {
                //A beer time is after 1:00 PM and before 3:00 AM.
                //Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
                //and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: 
                //You may need to learn how to parse dates and times.

            Console.WriteLine("Enters a time in format “hh:mm tt”(Example: 1:00 PM): ");
            DateTime myDateTime = DateTime.Parse(Console.ReadLine());
            if (myDateTime.Hour < 13 && myDateTime.Hour >= 3)
            {
                Console.WriteLine("It's non-beer time.");
            }
            else
            {
                Console.WriteLine("It's beer time!");
            }
        }
    }
