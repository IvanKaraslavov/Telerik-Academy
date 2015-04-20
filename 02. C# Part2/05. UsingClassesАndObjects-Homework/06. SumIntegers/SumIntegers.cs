﻿using System;
using System.Linq;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a sequence of integer numbers, separated by a single space: ");
            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(nums.Sum());
        }
    }

