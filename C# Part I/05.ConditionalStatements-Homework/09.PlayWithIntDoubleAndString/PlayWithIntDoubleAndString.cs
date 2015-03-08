using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
                    //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
                    //If the variable is int or double, the program increases it by one.
                    //If the variable is a string, the program appends * at the end.
                    //Print the result at the console. Use switch statement.

            Console.WriteLine("Please, choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your type: {0}", n);
            if (n == 1)
            {
                Console.WriteLine("Please, enter a number: ");
                int ifN = int.Parse(Console.ReadLine());
                int firstIfN = ifN + 1;
                Console.WriteLine("Your number increased by one is: {0}", firstIfN);
            }
            else if (n == 2)
            {
                Console.WriteLine("Please, enter a number: ");
                double elseIfN = double.Parse(Console.ReadLine());
                double secondIfN = elseIfN + 1;
                Console.WriteLine("Your number increased by one is: {0}", secondIfN);
            }
            else
            {
                Console.WriteLine("Please, enter a string: ");
                string elseN = Console.ReadLine();
                object stringEnd = elseN + "*";
                Console.WriteLine("Your string is: {0}", stringEnd);
            }
        }
    }

