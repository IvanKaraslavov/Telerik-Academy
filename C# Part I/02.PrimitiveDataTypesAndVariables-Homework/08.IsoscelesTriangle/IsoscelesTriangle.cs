﻿using System;
using System.Text;

         //Write a program that prints an isosceles triangle of 9 copyright symbols ©

    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            char symbol = '\u00a9';
            Console.WriteLine("    {0}  \n   {0} {0} \n  {0}   {0} \n {0} {0} {0} {0}", symbol);
        }
    }

