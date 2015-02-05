using System;
using System.Numerics;

namespace Example_06b_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = SuperSum(100000);

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static BigInteger SuperSum(BigInteger n)
        {
            if (n < 1)
                return 0;
            return n + SuperSum(n - 1);
        }
    }
}
