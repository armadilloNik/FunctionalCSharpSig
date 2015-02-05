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
            return (x, y) => x + y;
        }
    }
}
