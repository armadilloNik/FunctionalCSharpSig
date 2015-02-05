using System;

namespace Example_03b_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composition Example \n");

            Func<int, int> square = x => x*x;
            Func<int, int> twice = x => x + x;

            Func<int, int> doubleSquare = x => twice(square(x));

            Console.WriteLine(doubleSquare(3));

            Console.ReadLine();

        }
    }
}
