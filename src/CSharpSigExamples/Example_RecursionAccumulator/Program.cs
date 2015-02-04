using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Example_RecursionAccumulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = SuperSumAcc(100000, 0);

            Console.WriteLine(result);
            Console.WriteLine(SuperSum(100000));
            Console.ReadLine();
           

        }

        private static BigInteger SuperSum(BigInteger n)
        {
            if (n < 1)
                return 0;
            return n + SuperSum(n - 1);
        }

        // 64 bit release mode
        private static BigInteger SuperSumAcc(BigInteger n, BigInteger current)
        {
            if (n < 1)
                return current;
            return SuperSumAcc(n - 1, current + n);
        }

       
    }
}
