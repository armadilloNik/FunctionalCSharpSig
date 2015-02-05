using System;
using System.Numerics;

namespace Example_06a_RecursionC
{
    class Program
    {
        static void Main(string[] args)
        {
            // has to be 64 bit Release build!
            var sum = SuperSumAcc(100000, 0);

            Console.WriteLine(sum);
            
        }


        // tail call
        private static BigInteger SuperSumAcc(BigInteger n, BigInteger current)
        {
            if (n < 1)
                return current;
            return SuperSumAcc(n - 1, current + n);
        }
    }
}
