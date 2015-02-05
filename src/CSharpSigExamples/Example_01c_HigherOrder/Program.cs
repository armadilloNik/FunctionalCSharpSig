using System;

namespace Example_01c_HigherOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var both = HigherOrderFunctionBoth(x => x * x);

            var bothResult = both(1, 5);
            Console.WriteLine(bothResult);
            Console.ReadLine();
        }

        static Func<int, int, int> HigherOrderFunctionBoth(Func<int, int> myFunction)
        {
            return (x, y) => myFunction(x) + myFunction(y);
        }
    }
}
