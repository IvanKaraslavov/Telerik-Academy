using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7.

            Console.WriteLine("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n / 100;
            int nEnd = lastDigit % 10;
            bool isThirdDigit7 = lastDigit ==7;
            Console.WriteLine(isThirdDigit7);
           
        }
    }

