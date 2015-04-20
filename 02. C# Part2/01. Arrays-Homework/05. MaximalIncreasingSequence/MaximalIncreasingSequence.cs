using System;
using System.Collections.Generic;
using System.Linq;

    class MaximalIncreasingSequence
    {
        static void Main()
        {
            //Write a program that finds the maximal increasing sequence in an array.

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
            int minCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentNum = nums[i];
                currentCount = 0;
                for (int j = i; i < nums.Length; j++)
                {
                    if ( j == nums.Length - 1)
                    {
                        goto FOO;
                    }
                    if (nums[j] != nums[j + 1] - 1)
                    {
                        break;
                    }
                    currentCount++;
                }
                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    maxNum = currentNum;
                    minCount = currentNum;
                }
            }
            FOO:
            int index = 0;
            for (int i = minCount; i < minCount + maxCount + 1; i++)
            {
                
                Console.Write(minCount + index);
                index++;
                if (i != minCount + maxCount)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }

