using System;

namespace Example_01b_HigherOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var asReturnValue = HigherOrderFunctionAsReturnValue();

            var result = asReturnValue(1, 5);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static Func<int, int, int> HigherOrderFunctionAsReturnValue()
        {
            return Sum; //(x, y) => x + y;
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
