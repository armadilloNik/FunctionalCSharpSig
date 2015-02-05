using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var asParameter = HigherOrderFunctionAsParameter(10, x => x*x);
            
            Console.WriteLine(asParameter);
            Console.ReadLine();
         
        }

        static int HigherOrderFunctionAsParameter(int myVerySpecialArgument, Func<int, int> myFunction)
        {
            return myFunction(myVerySpecialArgument);
        }

    }
}
