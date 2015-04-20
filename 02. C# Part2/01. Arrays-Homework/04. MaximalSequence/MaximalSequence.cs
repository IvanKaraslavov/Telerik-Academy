using System;
using System.Linq;

    class MaximalSequence
    {
        static void Main()
        {
            //Write a program that finds the maximal sequence of equal elements in an array.

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

            int currentNum = nums[0];
            int maxNum = nums[0];
            int currentCount = 0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length;)
            {
                currentNum = nums[i];
                currentCount = 0;
                for (; i < nums.Length; i++)
                {
                    if (currentNum != nums[i])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    maxNum = currentNum;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum);
                if (i != maxCount - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }

