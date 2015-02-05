using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_02_Purity
{
    class Program
    {
        static void Main(string[] args)
        {
            //hidden side effect



            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" {0}", SideEffectSum(2, 3));
            }

            Console.ReadLine();
        }

        private static int SideEffectSum(int a, int b)
        {
            return a + b + ReadValueFromDb();
        }

        //ok so not really database
        private static int ReadValueFromDb()
        {
            Thread.Sleep(1000);
            return new Random().Next() % 2;
        }
    }
}
