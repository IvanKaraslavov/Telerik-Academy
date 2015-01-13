using System;

        //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        //Print the variable values before and after the exchange.

    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = 0;
            Console.WriteLine("Values before exchange:");
            Console.WriteLine("а = {0} ",a);
            Console.WriteLine("b = {0} ", b);
            Console.WriteLine(new string('-', 30));
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Values after exchange:");
            Console.WriteLine("а = {0} ", a);
            Console.WriteLine("b = {0} ", b);
            Console.WriteLine(new string('-', 30));
        }
    }

