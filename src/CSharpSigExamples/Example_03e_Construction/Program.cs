using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example_03e_Construction
{
    class Program
    {
        // curried Curry

        static void Main(string[] args)
        {
            //Start off here
            //Func<int, Func<int, int>> curriedIncrementByFactory = x => (y => Sum(x, y));

            //write this
            Func<int, Func<int, int>> curriedIncrementByFactory = MakeItSpicy<int, int, int>(Sum);

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
