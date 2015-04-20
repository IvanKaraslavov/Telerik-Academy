using System;

class Program
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n).

        Console.WriteLine("Enter the length of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int i = 1;
        for (int c = 0; c < n; c++)
        {
            if (c % 2 == 0)
            {
                for (int r = 0; r < n; r++)
                {
                    matrix[r, c] = i;
                    i++;
                }
            }
            else
            {
                for (int r = n - 1; r >= 0; r--)
                {
                    matrix[r, c] = i;
                    i++;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

