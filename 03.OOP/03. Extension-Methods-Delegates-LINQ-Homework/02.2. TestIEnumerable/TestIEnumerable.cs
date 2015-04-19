using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIEnumerable
{
    public class TestIEnumerable
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(10);
            list.Add(15);
            list.Add(35);
            list.Add(11);
            Console.WriteLine("Min: {0}", list.Min());
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Sum: {0}", list.Sum());
            Console.WriteLine("Average: {0}", list.Average());
        }
    }
}
