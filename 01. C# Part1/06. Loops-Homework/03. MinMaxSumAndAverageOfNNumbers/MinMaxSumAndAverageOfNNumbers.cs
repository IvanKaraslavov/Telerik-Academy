using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how many numbers you want and then enter them: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int? max = null;
            int? min = null;
            double avg = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (max == null || number >= max)
                {
                    max = number;
                }
                if (min == null || number <= min)
                {
                    min = number;
                }
                
            }
            avg = (double)sum / (double)n;
            Console.WriteLine("Max: {0} \nMin: {1} \nSum: {2} \nAvg: {3:F2}", max,min,sum,avg);
        }
    }

