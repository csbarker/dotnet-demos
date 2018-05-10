using System;
using System.Collections.Generic;

namespace collections_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithStrings();
            WorkingWithFibonnaciNumbers();
        }

        public static void WorkingWithFibonnaciNumbers()
        {
            var FibonacciNumbers = new List<int> { 1, 1 };

            while (FibonacciNumbers.Count < 20)
            {
                var previous = FibonacciNumbers[FibonacciNumbers.Count - 1];
                var previous2 = FibonacciNumbers[FibonacciNumbers.Count - 2];
                FibonacciNumbers.Add(previous + previous2);
            }

            Console.WriteLine(FibonacciNumbers.Count);
            Console.WriteLine(FibonacciNumbers[0]);
            Console.WriteLine(FibonacciNumbers[1]);
            Console.WriteLine(FibonacciNumbers[FibonacciNumbers.Count - 1]);
        }

        public static void WorkingWithStrings() {
            var names = new List<string> { "Callum", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();

            // modifying a list dynamically
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // using an index
            Console.WriteLine($"My name is {names[0]}");

            // counting
            Console.WriteLine($"The list has {names.Count} names in it");

            // searching
            Console.WriteLine();

            var indexes = new List<int> {
                names.IndexOf("Felipe"),
                names.IndexOf("NotFound")
            };

            foreach (var index in indexes)
	        {
                if (index == -1)
                {
                    Console.WriteLine($"When an index is not found it returns {index}");
                } else
                {
                    Console.WriteLine($"The name of {names[index]} is at index {index}");
                }
	        }

            // sorting
            Console.WriteLine();

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }
    }
}
