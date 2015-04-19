using System;
using System.Text;
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double division = firstNumber - secondNumber;
            bool equal = Math.Abs(division) < 0.000001;

            Console.WriteLine("Are the numbers equal with precision 0.000001? {0}", equal ? "True" : "False ");
        }
    }

