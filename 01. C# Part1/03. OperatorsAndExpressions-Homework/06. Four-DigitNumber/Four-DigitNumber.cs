using System;

    class Program
    {
        static void Main()
        {
            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
            //Prints on the console the number in reversed order: dcba (in our example 1102).
            //Puts the last digit in the first position: dabc (in our example 1201).
            //Exchanges the second and the third digits: acbd (in our example 2101).

            Console.WriteLine("Please enter a four-digit number:");
            int n = int.Parse(Console.ReadLine());
            int a = n / 1000;
            int aDigit = a % 10;
            int b = n / 100;
            int bDigit = b % 10;
            int c = n / 10;
            int cDigit = c % 10;
            int d = n ;
            int dDigit = d % 10;
            int sum = aDigit + bDigit + cDigit + dDigit;
            int reversed = (dDigit * 1000) + (cDigit * 100) + (bDigit * 10) + aDigit;
            int lastDigitInFront = (dDigit * 1000) + (aDigit * 100) + (bDigit * 10) + cDigit;
            int secondAndThirdDigitExchange = (aDigit * 1000) + (cDigit * 100) + (bDigit * 10) + dDigit;
            Console.WriteLine("The sum of the digits is: {0}", sum);
            Console.WriteLine("The reversed number is: {0}", reversed);
            Console.WriteLine("The number with the last digit in front is: {0}", lastDigitInFront);
            Console.WriteLine("The number with the second and third digit echange is: {0}", secondAndThirdDigitExchange);
        }
    }

