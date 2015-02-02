using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example_Lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Sum = (a, b) => a + b;
            
            Func<int, int> Square = x => x*x;

            Func<int, int> Double = x => x + x;

            Func<int, int> dubSq = z => Double(Square(z));

            Func<int, int, int> LazyTransform = (x, y) => Sum(dubSq(x), dubSq(y));


            var result = LazyTransform(2, 5);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
