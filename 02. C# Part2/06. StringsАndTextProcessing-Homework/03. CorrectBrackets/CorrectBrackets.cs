using System;
using System.Linq;
using System.Collections.Generic;

//Write a program to check if in a given expression the brackets are put correctly.

    class CorrectBrackets
    {
        private static readonly char[] OpenParentheses = { '(', '[', '{' };
        private static readonly char[] CloseParentheses = { ')', ']', '}' };
        static void Main()
        {
            Console.Write("Enter an expression with brackets: ");
            string expression = Console.ReadLine();

            CheckExpression(expression);
            Console.WriteLine(CheckExpression(expression)
                ? "The brackets in your expression are put correctly."
                : "The brackets in your expression are put incorrectly or are missing.");
        }

        private static bool CheckExpression(string input)
        {
            Stack<int> parentheses = new Stack<int>();

            foreach (char chr in input)
            {
                int index;

                if ((index = Array.IndexOf(OpenParentheses, chr)) != -1)
                {
                    parentheses.Push(index); 
                }
                else if ((index = Array.IndexOf(CloseParentheses, chr)) != -1)
                {
                    if (parentheses.Count == 0 || parentheses.Pop() != index) return false;
                }
            }
            return parentheses.Count == 0;
        }
        }
    

