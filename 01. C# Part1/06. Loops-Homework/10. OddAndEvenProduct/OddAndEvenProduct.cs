using System;

class OddAndEvenProduct
{
    static void Main()
    {
            //You are given n integers (given in a single line, separated by a space).
            //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

        int even = 1;
        int odd = 1;
        Console.WriteLine("Enter your numbers in a single line, separated by a space:");
        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                even *= number;
            }
            else
            {
                odd *= number;
            }

        }
        if (even == odd)
        {
            Console.WriteLine("Result: yes");
            Console.WriteLine("Product: {0}", even);
        }
        else
        {
            Console.WriteLine("Result: no");
            Console.WriteLine("Odd_Product: {0}", odd);
            Console.WriteLine("Even_Product: {0}", even
);
        }
    }
}


