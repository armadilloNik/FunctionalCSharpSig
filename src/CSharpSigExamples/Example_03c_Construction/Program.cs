using System;

namespace Example_03c_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            //partial application

            Func<int, int> IncrementBy5 = x => Sum(x, 5);

            Console.WriteLine(IncrementBy5(1));

        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
