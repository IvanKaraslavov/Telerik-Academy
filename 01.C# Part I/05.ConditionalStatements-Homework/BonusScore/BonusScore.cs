using System;

    class BonusScore
    {
        static void Main()
        {
                //Write a program that applies bonus score to given score in the range [1…9] by the following rules:
                //If the score is between 1 and 3, the program multiplies it by 10.
                //If the score is between 4 and 6, the program multiplies it by 100.
                //If the score is between 7 and 9, the program multiplies it by 1000.
                //If the score is 0 or more than 9, the program prints “invalid score”.

            Console.WriteLine("Write your number(1...9): ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 3)
            {
                int firstN = n * 10;
                Console.WriteLine("Result: {0}", firstN);
            }
            else if (n >= 4 && n <= 6)
            {
                int secondN = n * 100;
                Console.WriteLine("Result: {0}", secondN);
            }
            else if (n >= 7 && n <= 9)
            {
                int thirdN = n * 1000;
                Console.WriteLine("Result: {0}", thirdN);

            }
            else
            {
                Console.WriteLine("Invalid score.");
            }
        }
    }

