using System;
using System.Linq;

//Write a program that finds how many times a sub-string is contained in a given text 
//(perform case insensitive search).

    class SubStringInText
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string target = Console.ReadLine();

            Console.WriteLine("Enter a text where we are going to looking for in our string:");
            string text = Console.ReadLine();
            int count = 0;
            int number = FindTheTextInTarget(target,text, count);
            Console.WriteLine("The result is: {0}", number);

        }

        private static int FindTheTextInTarget(string target, string text, int count)
        {
            string upperTarget = target.ToUpper();
            string upperText = text.ToUpper();
            int index = -1;
            while (true)
            {
                index = index + 1;
                index = upperTarget.IndexOf(upperText, index);
                if (index == -1)
                {
                    break;
                }
                count++;
            }
            return count;
        }
    }

