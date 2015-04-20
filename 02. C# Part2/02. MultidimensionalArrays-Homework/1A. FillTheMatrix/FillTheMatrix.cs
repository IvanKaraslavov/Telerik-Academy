using System;

    class FillTheMatrix
    {
        static void Main()
        {
            //Write a program that fills and prints a matrix of size (n, n).

            Console.WriteLine("Enter the length of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array1 = new int[n,n];
            int index = 1;
            for (int col = 0; col < array1.GetLength(1); col++)
            {
                for (int row = 0; row < array1.GetLength(0); row++, index++)
                {
                    array1[row, col] = index;
                }
            }
            for (int row = 0; row < array1.GetLength(0); row++)
            {
                for (int col = 0; col < array1.GetLength(1); col++)
                {
                    Console.Write(array1[row, col] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }

