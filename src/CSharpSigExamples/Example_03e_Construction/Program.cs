using System;

namespace Example_03e_Construction
{
    class Program
    {
        // curried Curry

        static void Main(string[] args)
        {
            Func<int, Func<int, int>> curriedIncrementByFactory = x => (y => Sum(x, y));
            
            //Func<int, Func<int, int>> curriedIncrementByFactory = MakeItSpicy<int, int, int>(Sum);

            var incrementby10 = curriedIncrementByFactory(10);

            Console.WriteLine(incrementby10(1));

            Console.ReadLine();

        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        static Func<T, Func<V, R>> MakeItSpicy<T, V, R>(Func<T, V, R> func)
        {
            return t => v => func(t, v);
        } 
    }
}
