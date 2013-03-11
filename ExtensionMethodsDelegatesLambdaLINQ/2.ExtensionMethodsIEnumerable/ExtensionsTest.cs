namespace ExtensionMethodsIEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ExtensionsTest
    {
        static void Main()
        {
            int[] numbers = {2, 5, 10, 1};
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine("Min is {0}", numbers.Min());
            Console.WriteLine("Max is {0}", numbers.Max());
            Console.WriteLine("Average is {0}", numbers.Average());

            var doubles = new List<double> {1.3, 2.5, 34.8};
            Console.WriteLine(doubles.Min());
            Console.WriteLine(doubles.Product());

            // Next code will throw an exception

            int[] numbers2 = new int[0];
            Console.WriteLine("Max is {0}", numbers2.Max());

            
        }
    }
}
