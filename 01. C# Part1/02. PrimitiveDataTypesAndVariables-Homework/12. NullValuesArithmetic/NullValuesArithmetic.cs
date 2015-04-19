using System;

                //Create a program that assigns null values to an integer and to a double variable.
                //Try to print these variables at the console.
                //Try to add some number or the null literal to these variables and print the result.

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intNullVariable = null;
            double? doubleNullVariable = null;
            Console.WriteLine(intNullVariable);
            Console.WriteLine(doubleNullVariable);
            intNullVariable += 6;
            doubleNullVariable += 333;
            Console.WriteLine(intNullVariable);
            Console.WriteLine(doubleNullVariable);
        }
    }

