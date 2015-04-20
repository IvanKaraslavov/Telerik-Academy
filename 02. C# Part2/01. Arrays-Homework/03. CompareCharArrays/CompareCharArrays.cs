using System;

class CompareCharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        Console.WriteLine("Enter the length of the first array: ");
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];

        Console.WriteLine("Please write every element of the first array(on separate lines):");
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the length of the first array: ");
        int n2 = int.Parse(Console.ReadLine());
        char[] secondArray = new char[n2];

        Console.WriteLine("Please write every element of the second array(on separate lines):");
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        if (firstArray.Length != secondArray.Length)
        {
            areEqual = false;
            Console.WriteLine("The two arrays have different length.");
        }
        if (areEqual)
        {
            Console.WriteLine("The two arrays have equal length.");

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0} > {1} The bigger element is {0} from the first array.", firstArray[i], secondArray[i]);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("{0} < {1} The bigger element is {1} from the second array.", firstArray[i], secondArray[i]);
                }
                else if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} = {0} The two elements are equal.", secondArray[i]);
                }
            }
        }
    }
}
