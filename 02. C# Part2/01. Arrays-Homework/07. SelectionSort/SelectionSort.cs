using System;
using System.Collections.Generic;

class SelectionSort
{
    static void Main()
    {
                //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
                //Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
                //smallest from the rest, move it at the second position, etc.

        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int minValue = int.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            minValue = int.MaxValue;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < minValue)
            {
                minValue = array[j];
                minIndex = j;
            }
        }
        int temp = array[i];
        array[i] = minValue;
        array[minIndex] = temp;
        }
        Console.WriteLine(string.Join(", ", array));
    }
}