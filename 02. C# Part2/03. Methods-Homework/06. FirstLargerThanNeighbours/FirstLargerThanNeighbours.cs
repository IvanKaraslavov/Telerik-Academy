using System;
using System.Linq;

        //Write a method that returns the index of the first element in array that is larger 
        //than its neighbours, or -1, if there’s no such element.
        //Use the method from the previous exercise.

    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integers of the array: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int firstLarger = FirstLarger(numbers);
            Console.WriteLine("The first larger number is: {0}", firstLarger);
        }

        private static int FirstLarger(int[] numbers)
        {
            for (int i = 1; i < numbers.Length -1; i++)
            {
                if (numbers[i ] > numbers[i + 1] && numbers[i ] > numbers[i + 1])
                {
                    return numbers[i];
                }
            }
            return -1;
        }
    }

