using System;
using System.Linq;

    class FrequentNumber
    {
        static void Main()
        {
            //Write a program that finds the most frequent number in an array.

            string input = Console.ReadLine();
            string[] array = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[array.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(array[i]);
            }
            int[] numbers = input
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            Array.Sort(array);
            int counter = 0;
            int bigCounter = 0;
            int whatNum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    if (bigCounter <= counter)
                    {
                        bigCounter = counter;
                        whatNum = numbers[i];
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            Console.WriteLine("{0} ({1} times)", whatNum, bigCounter + 1);
        }
    }

