using System;

    class DivideBy7And5
    {
        static void Main()
        {
            //Write a Boolean expression that checks for given integer if it can be divided 
            //(without remainder) by 7 and 5 at the same time.

            Console.WriteLine("Write your number:");
            int number = int.Parse(Console.ReadLine());
            bool divided = (number % 35.0 == 0);
            Console.WriteLine(divided);
        }
    }

