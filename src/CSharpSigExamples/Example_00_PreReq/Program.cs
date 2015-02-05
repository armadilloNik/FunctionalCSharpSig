using System;

namespace Example_00_PreReq
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> myFunction = (x) => x + 1;

            var result = myFunction(10);

            Console.WriteLine(10);
            Console.ReadLine();
        }
    }
}
