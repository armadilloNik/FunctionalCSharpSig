using System;

namespace Example_03d_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            //currying
            
            Func<int, Func<int, int>> curriedIncrementByFactory = x => (y => Sum(x, y));

            var incrementby10 = curriedIncrementByFactory(10);
            var incrementby20 = curriedIncrementByFactory(20);

            Console.WriteLine(incrementby10(1));
            Console.WriteLine(incrementby20(1));

            Console.ReadLine();

        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
