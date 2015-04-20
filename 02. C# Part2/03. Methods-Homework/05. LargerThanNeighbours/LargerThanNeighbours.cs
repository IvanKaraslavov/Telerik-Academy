using System;
using System.Linq;

        //Write a method that checks if the element at given position in given array of integers 
        //is larger than its two neighbours (when such exist).

     public class LargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Enter the integers of the array: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Console.WriteLine("Enter the position of the number in the array: ");
            int position = int.Parse(Console.ReadLine());
            if (position > numbers.Length)
            {
                Console.WriteLine("There is no such position.");
            }
            bool isLarger = IsTheNumberLarger(numbers, position);
            Console.WriteLine("Is the number larger? {0}", isLarger);  
        }

        public static bool IsTheNumberLarger(int[] numbers, int position)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[position] == numbers[numbers.Length - 1] || numbers[position] == numbers[0])
                {
                    Console.WriteLine("The number doesn't have two neighbours.");
                    break;
                }
                if (numbers[position] > numbers[position + 1] && numbers[position] > numbers[position - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }

