﻿using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        //Write a program that finds the sequence of maximal sum in given array.

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


        int currentSum = numbers[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = numbers[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = numbers[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += numbers[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;

                startIndex = tempStartIndex;
                endIndex = i;
            }
        }

        Console.WriteLine("The sum is: {0} ", maxSum);

        Console.WriteLine("The sequence is:");

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0}",array[i]);
            if (i != endIndex)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}