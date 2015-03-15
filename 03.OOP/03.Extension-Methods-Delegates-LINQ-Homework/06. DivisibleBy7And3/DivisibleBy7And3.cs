namespace DivisibleBy7And3
{
    //Write a program that prints from given array of integers all numbers that are
    //divisible by 7 and 3. Use the built-in extension methods and lambda expressions.

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 2, 7, 1, 9, 3, 32, 65, 12, 34, 21, 63, 49, 56 };

            var result = numbers.
                Where(nb => nb % 7 == 0 && nb % 3 == 0)
                .Select(nb => nb);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
