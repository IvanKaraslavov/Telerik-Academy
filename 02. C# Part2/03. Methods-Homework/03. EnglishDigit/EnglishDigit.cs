using System;

    //Write a method that returns the last digit of given integer as an English word.

    class EnglishDigit
    {
        static string word = null;
        static int lastDigit = 0;
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            LastDigit(LastDigit(input));
            EnglishWord(lastDigit);
        }

        private static void EnglishWord(int input)
        {
            switch (input)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
            }
            Console.WriteLine(word);
        }

        private static int LastDigit(int input)
        {
            return lastDigit = input % 10;
            
        }
    }

