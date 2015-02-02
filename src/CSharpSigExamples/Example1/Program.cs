using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var asParameter = HigherOrderFunctionAsParameter(10, x => x*x);
            
            Console.WriteLine(asParameter);
            Console.ReadLine();

            var asReturnValue = HigherOrderFunctionAsReturnValue();

            var result = asReturnValue(1, 5);
            
            Console.WriteLine(result);
            Console.ReadLine();

            var both = HigherOrderFunctionBoth(x => x*x);

            var bothResult = both(1, 5);
            Console.WriteLine(bothResult);
            Console.ReadLine();
        }

        static int HigherOrderFunctionAsParameter(int myVerySpecialArgument, Func<int, int> myFunction)
        {
            return myFunction(myVerySpecialArgument);
        }

        static Func<int, int, int> HigherOrderFunctionAsReturnValue()
        {
            return (x, y) => x + y;
        }

        static Func<int, int, int> HigherOrderFunctionBoth(Func<int, int> myFunction)
        {
            return (x, y) => myFunction(x) + myFunction(y);
        }

    }
}
