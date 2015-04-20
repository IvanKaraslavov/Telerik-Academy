using System;

class MaximalSum
{
    static void Main()
    {
        //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
        //that has maximal sum of its elements.

        Console.WriteLine("Write N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Write M: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Matrix[{0} {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());

            }
        }
        int platformX = 3;
        int platformY = 3;
        int maxSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - (platformX - 1); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - (platformY - 1); col++)
            {
                int currentSum = 0;
                for (int i = row; i < row + platformX; i++)
                {
                    for (int j = col; j < col + platformY; j++)
                    {
                        currentSum += matrix[i, j];

                    }
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}

