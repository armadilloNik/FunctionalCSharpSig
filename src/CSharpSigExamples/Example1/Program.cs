using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var asParameter = HigherOrderFunctionAsParameter(10, x => x*x);

            Console.WriteLine(asParameter);
            Console.ReadLine();

        }

        private static int HigherOrderFunctionAsParameter(int myVerySpecialArgument, Func<int, int> myFunction)
        {
            Console.WriteLine("Logged value: {0}", myVerySpecialArgument);
            return myFunction(myVerySpecialArgument);
        }

    }
}
