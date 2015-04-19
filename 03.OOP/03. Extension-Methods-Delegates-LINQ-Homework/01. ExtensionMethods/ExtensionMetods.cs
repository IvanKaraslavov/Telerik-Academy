namespace ExtensionMetods
{
    //Implement an extension method Substring(int index, int length) for the class StringBuilder
    //that returns new StringBuilder and has the same functionality as Substring in the class String.
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ExtensionMetods
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(sb[startIndex + i]);
            }
            return result;
        }

        //Implement a set of extension methods for IEnumerable<T> that implement the
        //following group functions: sum, product, min, max, average.

        public static T Sum<T>(this IEnumerable<T> numbers)
        {
            decimal result = 0;

            foreach (dynamic item in numbers)
                result += (decimal)item;

            return (T)(dynamic)result;
        }

        public static T Product<T>(this IEnumerable<T> numbers)
        {
            decimal result = 1;

            foreach (dynamic item in numbers)
                result *= (decimal)item;

            return (T)(dynamic)result;
        }

        public static T Min<T>(this IEnumerable<T> numbers)
            where T : IComparable<T>
        {
            if (numbers.Count() == 0)
                throw new ArgumentException("Cannot estimate max value of empty collection.");

            T minValue = numbers.First();

            foreach (T item in numbers)
            {
                if (item.CompareTo(minValue) < 0)
                    minValue = item;
            }

            return (T)(dynamic)minValue;
        }

        public static T Max<T>(this IEnumerable<T> numbers)
            where T : IComparable<T>
        {
            if (numbers.Count() == 0)
                throw new ArgumentException("Cannot estimate max value of empty collection.");

            T maxValue = numbers.First();

            foreach (T item in numbers)
            {
                if (item.CompareTo(maxValue) > 0)
                    maxValue = item;
            }

            return (T)(dynamic)maxValue;
        }

        public static T Average<T>(this IEnumerable<T> numbers)
             where T : IComparable<T>
        {
            if (numbers.Count() == 0)
                throw new ArgumentException("Cannot estimate average value of empty collection.");

            decimal sum = 0;
            int count = 0;

            foreach (dynamic item in numbers)
            {
                sum += (decimal)item;
                count++;
            }

            return (T)(dynamic)(sum / (decimal)count);
        }

        class MainMethod
        {
            public static void Main()
            {

            }
        }
    }
}
