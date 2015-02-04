using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_07_TheRoadWellTravelled
{
    class Program
    {
        static void Main(string[] args)
        {
            //should probably make this 2 sepearate code examples

            Console.WriteLine("press a key");
            Console.ReadLine();

            PrintExpensiveSum(2,3);
            PrintExpensiveSum(1,5);
            PrintExpensiveSum(2,3);
            PrintExpensiveSum(2,3);
            PrintExpensiveSum(2,4);
            
            Console.ReadLine();

            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(1, 5);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 3);
            PrintMemoizedSum(2, 4);

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

        static Dictionary<string, int> _sumMemoizer = new Dictionary<string, int>(); 
        
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
