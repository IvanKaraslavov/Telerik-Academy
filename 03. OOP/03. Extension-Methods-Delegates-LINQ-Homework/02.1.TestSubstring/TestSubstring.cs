using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtensionMetods;

namespace TetsSubstring
{
    public class TetsSubstring
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("I want |this| to remain.");
            Console.WriteLine(sb.ToString());
            sb = sb.Substring(7, 6);
            Console.WriteLine(sb.ToString());

        }
    }
}
