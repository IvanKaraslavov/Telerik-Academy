using System;
using System.Linq;

        //Write a program that can solve these tasks:
        //Reverses the digits of a number
        //Calculates the average of a sequence of integers
        //Solves a linear equation a * x + b = 0
        //Create appropriate methods.
        //Provide a simple text-based menu for the user to choose which task to solve.
        //Validate the input data:
        //The decimal number should be non-negative
        //The sequence should not be empty
        //a should not be equal to 0
class SolveTasks
{
    static void Main()
    {
        Console.WriteLine(@"Choose a task:
1 -> Reverses the digits of a number
2 -> Calculates the average of a sequence of integers
3 -> Solves a linear equation a * x + b = 0
");
        Console.WriteLine("Your decision:");
        byte decision = byte.Parse(Console.ReadLine());
        if (decision == 1)
        {
            ReverseTheDigitsInTheNumber();
        }
        else if (decision == 2)
        {
            CalculateTheAverageInt();
        }
        else if (decision == 3)
        {
            SolvesALinearEquation();
        }
        else
        {
            Console.WriteLine("Please choose from 1 to 3.");
        }

    }

    private static void SolvesALinearEquation()
    {
        Console.WriteLine("Please enter a:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter b:");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal reversedB = -b;
        decimal x = reversedB / a;
        Console.WriteLine("X = {0:F2}", x);
    }

    private static void CalculateTheAverageInt()
    {
        Console.WriteLine("Enter the integers of the array on one line with commas: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        decimal product = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            product += numbers[i];
        }
        decimal result = product / numbers.Length;
        Console.WriteLine("The average of the sequence of the integers is: {0}", result);
    }

    private static void ReverseTheDigitsInTheNumber()
    {
        Console.WriteLine("Enter a non-negative integer number: ");
        int input = int.Parse(Console.ReadLine());
        if (input < 0)
        {
            Console.WriteLine("Enter a non-negative integer number!");
        }
        int reversed = ReversedNumber(input);
        Console.WriteLine("The reversed number: {0}", reversed);
    }

    private static int ReversedNumber(int input)
    {
        int result = 0;
        while (input > 0)
        {
            result = result * 10 + input % 10;
            input /= 10;
        }
        return result;
    }
}

