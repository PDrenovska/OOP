using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ExtensionMethodsIEnumerable
{
    public static class ExtensionMethods
    {
        // Extension method that implements the function sum
        public static decimal Sum<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = default(T);
            foreach (var item in enumeration)
            {
                sum += item;
            }
            return sum;
        }

        // Extension method that implements the function product
        public static decimal Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic product = 1;
            foreach (var item in enumeration)
            {
                product *= item;
            }
            return Convert.ToDecimal(product);
        }

        // Extension method that implements the function min
        public static decimal Min<T>(this IEnumerable<T> enumeration)
        {
            // The Any() method returns true if the source sequence contains any elements; otherwise, returns false.
            if (!enumeration.Any())
            {
                throw new ArgumentException("The collection is empty");
            }
            decimal min = decimal.MaxValue;
            foreach (var item in enumeration)
            {
                decimal decimalItem = Convert.ToDecimal(item);
                if (decimalItem < min)
                {
                    min = decimalItem;
                }
            }
            return min;
        }

        // Extension method that implements the function max
        public static decimal Max<T>(this IEnumerable<T> enumeration)
        {
            if (!enumeration.Any())
            {
                throw new ArgumentException("The collection is empty");
            }
            decimal max = decimal.MinValue;
            foreach (var item in enumeration)
            {
                decimal decimalItem = Convert.ToDecimal(item);
                if (decimalItem > max)
                {
                    max = decimalItem;
                }
            }
            return max;
        }

        // Extension method that implements the function average;
        public static decimal Average<T>(this IEnumerable<T> enumeration)
        {
            if (!enumeration.Any())
            {
                throw new ArgumentException("The collection is empty");
            }
            return enumeration.Sum() / enumeration.Count();
        }
    }
}
