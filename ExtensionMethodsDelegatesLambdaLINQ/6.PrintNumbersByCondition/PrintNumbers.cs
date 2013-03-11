using System;
using System.Linq;

namespace PrintNumbersByCondition
{
    class PrintNumbers
    {
        // Program that prints from given array of integers all numbers that are divisible by 7 and 3;
        static void Main()
        {
            int[] numbers = { 5, 4, 21, 63, 9, 8, 16, 7, 42, 0 };

            // Using lambda expression
            var numsDivisbleby7and3 = numbers.Where(x => x%21 == 0);
            foreach (var num in numsDivisbleby7and3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            // Using LINQ query
            var numsDivisibleBy21 =
                from num in numbers
                where num % 21 == 0
                select num;

            foreach (var num in numsDivisibleBy21)
            {
                Console.Write(num + " ");
            }
            // The result is 21 63 42 0
            Console.WriteLine();
        }
    }
}
