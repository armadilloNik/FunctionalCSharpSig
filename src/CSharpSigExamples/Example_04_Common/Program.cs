using System;
using System.Collections.Generic;
using System.Linq;

namespace Example_04_Common
{
    class Program
    {
        private static void Main(string[] args)
        {
            var theList = Enumerable.Range(1, 10).ToList();

            theList.PrintList();

            //map
            var squaredList = theList.Select(item => item*item);
            squaredList.PrintList();

            //filter
            var filteredList = theList.Where(item => item%5 == 0);
            filteredList.PrintList();

            //fold
            var folded = theList.Aggregate((aggregateValue, currentValue) => aggregateValue*currentValue);
            Console.WriteLine(folded);

            Console.ReadLine();
        }
    }

    internal static class ext
    {
        public static void PrintList(this IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n\n");
        }
    }
}
