using System;
using System.Collections.Generic;
using System.Threading;

namespace Example_07b_TheRoadWellTravelled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press a key");
            Console.ReadKey();

            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(1, 5);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 4);

            Console.WriteLine("Done!");
            Console.ReadLine(); 
        }

        private static int ExpensiveSum(int a, int b)
        {
            Thread.Sleep(2000); // These are not the droids you're looking for

            return a + b;
        }

        private static Dictionary<string, int> _sumMemoizer = new Dictionary<string, int>(); 

        private static int MemoizeSum(int a, int b)
        {
            var key = string.Format("{0},{1}", a, b);

            if (_sumMemoizer.ContainsKey(key))
            {
                return _sumMemoizer[key];
            }

            var result = ExpensiveSum(a, b);
            _sumMemoizer.Add(key, result);

            return result;
        }

        private static void PrintMemoizedSum(int a, int b)
        {
            Console.Write("The Sum of {0} and {1} is: ", a, b);
            Console.WriteLine(MemoizeSum(a, b));
        }
    }
}
