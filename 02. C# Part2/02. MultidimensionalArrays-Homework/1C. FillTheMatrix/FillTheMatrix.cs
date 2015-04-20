﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintMatrixC
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n).

        Console.Write("Enter N: ");
        int n = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int rows = 0;
        int cols = 0;
        int value = 1;

        //populate values under the main diagonal
        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = value++;
            }
        }

        //populate values over the main diagonal
        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = value++;
            }
        }

        for (rows = 0; rows < n; rows++)
        {
            for (cols = 0; cols < n; cols++)
            {
                Console.Write(matrix[rows, cols] + " ");
            }
            Console.WriteLine();
        }

    }
}
