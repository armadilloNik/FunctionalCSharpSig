using System;
using System.Threading;

namespace Example_07_TheRoadWellTravelled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press a key");
            Console.ReadLine();

            PrintExpensiveSum(2,3);
            PrintExpensiveSum(1,5);
            PrintExpensiveSum(2,3);
            PrintExpensiveSum(2,3);
            PrintExpensiveSum(2,4);
            
            Console.ReadLine();
        }

        private static int ExpensiveSum(int a, int b)
        {
            Thread.Sleep(2000); // These are not the droids you're looking for

            return a + b;
        }

        private static void PrintExpensiveSum(int a, int b)
        {
            Console.Write("The Sum of {0} and {1} is: ", a, b);
            Console.WriteLine(ExpensiveSum(a, b));
        }
    }
}
