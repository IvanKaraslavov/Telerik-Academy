using System;

//Write a program to convert from any numeral system of given base s to any other 
//numeral system of base d (2 ≤ s, d ≤ 16).

    class OneSystemToAnyOther
    {
        static void Main()
        {
            Console.WriteLine("Please enter a S base: ");
            int sBase = int.Parse(Console.ReadLine());
            if (sBase < 2)
            {
                Console.WriteLine("Invalid Base.");
            }
            Console.WriteLine("Please enter a number: ");
            string number = Console.ReadLine();
            long toDecimal = ConvertToDecimal(number, sBase);
            Console.WriteLine("Please enter a D base: ");
            int dBase = int.Parse(Console.ReadLine());
            if (dBase < 2 || dBase > 32)
            {
                Console.WriteLine("Invalid Base.");
            }
            string fromDecimal = ConvertFromDecimal(toDecimal, dBase);
            Console.WriteLine("The number {0} from base {1} is {2} to base {3}", number, sBase,fromDecimal, dBase);
        }

        private static string ConvertFromDecimal(long toDecimal, int dBase)
        {
            string toBaseD = "";
            while (toDecimal > 0)
            {
                var digit = toDecimal % dBase;
                if (digit >= 0 && digit <= 9)
                {
                    toBaseD = (char)(digit + '0') + toBaseD;
                }
                else 
                {
                    toBaseD = (char)(digit - 10 + 'A') + toBaseD;
                }
                toDecimal = toDecimal / dBase;
            }
            return toBaseD;
        }
        static long ConvertToDecimal( string input, int sBase)
        {
            long number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    long digit = input[i] - '0';
                    number += digit * (long)Math.Pow(sBase, input.Length - i - 1);
                }
                else 
                {
                    long digit = input[i] - 'A' + 10;
                    number += digit * (long)Math.Pow(sBase, input.Length - i - 1);
                }
            }

            return number;
        }
    }

