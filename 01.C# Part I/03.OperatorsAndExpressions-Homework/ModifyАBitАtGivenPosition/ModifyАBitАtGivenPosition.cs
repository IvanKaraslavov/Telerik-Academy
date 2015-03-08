using System;

    class ModifyАBitАtGivenPosition
    {
        static void Main()
        {
                    // We are given an integer number n, a bit value v (v=0 or 1) and a position p.
                    //Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at 
                    //the position p from the binary representation of n while preserving all other bits in n.

            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a bit value(0 or 1):");
            int v = int.Parse(Console.ReadLine());
            if(v == 1)
            {
                int mask = 1 << p;
                int nAndMask = n | mask;
                Convert.ToString(nAndMask, 10);
                Console.WriteLine(nAndMask);
            }
            else if ( v == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Convert.ToString(result, 10);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a bit value 0 or 1!");
            }
            
        }
    }

