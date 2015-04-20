using System;

//Write a method that reverses the digits of given decimal number.

    class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a integer number: ");
            int input = int.Parse(Console.ReadLine());
            int reversed = ReversedNumber(input);
            Console.WriteLine("The reversed number: {0}", reversed);
        }

        private static int ReversedNumber(int input)
        {
            int result = 0;
            while (input > 0)
            {
                result = result * 10 + input % 10;
                input /= 10;
            }
            return result;
        }
    }

