﻿using System;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

    class MaximalAreaSum
    {
        static int[,] matrix;
        static int bestSum = 0;
        static void Main()
        {
            const string matrixPath = "../../matrix.txt";
            const string outputPath = "../../result.txt";

            InitializeMatrix(matrixPath);
            FindBestSumOfSquareInMatrix();
            WriteBestSumToTextFile(outputPath);

            Console.WriteLine("Best sum of square: {0}\n", bestSum);
        }

        static void InitializeMatrix(string pathMatrix)
        {
            using (StreamReader reader = new StreamReader(pathMatrix))
            {
                int row = 0;
                int length = int.Parse(reader.ReadLine());

                matrix = new int[length, length];

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < tokens.Length; i++)
                    {
                        matrix[row, i] = int.Parse(tokens[i]);
                    }

                    row++;
                }
            }
        }

        static void FindBestSumOfSquareInMatrix()
        {
            for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }
        }

        static void WriteBestSumToTextFile(string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                result.WriteLine(bestSum);
            }
        }
    }

