namespace BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BitArrayTest
    {
        static void Main()
        {
            const ulong number = 12345678901234567890;
            BitArray64 array1 = new BitArray64(number);
            BitArray64 array2 = new BitArray64(number / 2);

            Print(array1, "array1: ");
            Print(array2, "array2: ");

            Console.WriteLine("\n{0,-24} →  {1}", "array1.Equals(array2)", array1.Equals(array2));
            Console.WriteLine("{0,-24} →  {1}\n", "array1 != array2", array1 != array2);

            Console.WriteLine(array1);

            Console.WriteLine("array1[7] = {0}", array1[7]);
        }

        private static void Print(BitArray64 array1, string text)
        {
            Console.Write(text);
            foreach (var bit in array1)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
