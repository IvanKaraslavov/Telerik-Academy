﻿using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            //Write a program that reads an integer number n from the console and prints all the 
            //numbers in the interval [1..n], each on a single line.

            Console.WriteLine("Write your number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {

                Console.WriteLine("{0, 20}", i);
            }
        }
    }