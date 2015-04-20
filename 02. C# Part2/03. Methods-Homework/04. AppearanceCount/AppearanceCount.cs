using System;
using System.Linq;

        //Write a method that counts how many times given number appears in given array.
        //Write a test program to check if the method is workings correctly.

public class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter the integers of the array: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        Console.WriteLine("Enter a number you want to search: ");
        int searchNumber = int.Parse(Console.ReadLine());
        int index = 0;
        int count = CountElementAppearance(numbers, searchNumber, index);
        Console.WriteLine("The number {0} is found {1} times", searchNumber, count);


    }

    public static int CountElementAppearance(int[] numbers, int searchNumber, int index)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (searchNumber == numbers[i])
            {
                index++;
            }
        }
        return index;
    }
}

