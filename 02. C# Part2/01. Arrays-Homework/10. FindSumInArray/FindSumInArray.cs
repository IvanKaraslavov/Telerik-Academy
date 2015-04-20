using System;
using System.Linq;
    class FindSumInArray
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present).

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

            Console.WriteLine("Enter your sum: ");
            int s = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int start = 0;
            int end = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                currentSum += numbers[i];
                start = i;
                for (int p = i + 1; p < array.Length ; p++)
                {
                    currentSum += numbers[p];
                    end = p;
                    if (currentSum == s)
                    {
                        for (int m = start; m <= end; m++)
                        {
                            Console.Write("{0}", array[m]);
                            if (m != end)
                            {
                                Console.Write(", ");
                            }
                        }
                        return;
                    }
                    
                }
                currentSum = 0;
            }
            Console.WriteLine("The sum is not present in the array.");
        }
    }
