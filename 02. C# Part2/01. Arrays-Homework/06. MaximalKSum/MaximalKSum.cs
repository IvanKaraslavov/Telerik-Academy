using System;

    class MaximalKSum
    {
        static void Main()
        {
                //Write a program that reads two integer numbers N and K and an array of N elements from the console.
                //Find in the array those K elements that have maximal sum.

            Console.WriteLine("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            Console.WriteLine("Please write every element of the array(on separate lines):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Write K: ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (i < k)
                {
                    sum = sum + array[i];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("The max sum of K elements is: {0}", sum);
        }
    }

