using System;

namespace Exmaple_03_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleClosure();

           // ConstructIncrementByClosure();

            var myValue = .30f;

            Func<float, float> compute = x => x*myValue;
            ConsoleWritePercent(compute);

            Console.ReadLine();
        }

        static Func<int> SimpleClosure()
        {
            var val = 10;
            Func<int> internalAdd = () => val;

            Console.WriteLine(internalAdd());

            val = 30;
            Console.WriteLine(internalAdd());

            return internalAdd;
        }

        private static Func<int, int> ConstructIncrementByClosure()
        {
            var incrementBy = 5;
            Func<int, int> internalIncrement = x => x + incrementBy;

            Console.WriteLine(internalIncrement(2));

            return internalIncrement;
        }

        private static void ConsoleWritePercent(Func<float, float> percentComputation)
        {
            Console.WriteLine("\n {0}%", percentComputation(100));
        }
    }
}
