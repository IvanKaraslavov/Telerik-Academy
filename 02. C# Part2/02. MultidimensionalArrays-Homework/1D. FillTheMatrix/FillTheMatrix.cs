using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int index = 1;
            int k = 0;
            int i = 0;
            int j = 0;
            for (; i <= n-1; i++)
            {
                for (; j <= n-1; j++)
                {
                    Razvk(matrix, index, n, k,i,j);
                }
            }
        }

        private static void Razvk(int[,] matrix, int index, int n, int k, int i, int j)
        {
            i = k;
            for (i = k ; i <= n-k + 1; k++)
            {
                matrix[i, j] = index;
                index++;
                
            }
            for (j = n - k - 1; i < n - k - 1; i++)
            {
                matrix[i, j] = index;

            }
        }
    }

