using System;
using System.Linq;

namespace Example_05_ListComprehension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Project Euler Problem 1
            // example: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            //The problem: Find the sum of all the multiples of 3 or 5 below 1000

            var answer = Enumerable.Range(1, 999).Where(number => (number%5 == 0) || (number%3 == 0)).Aggregate((agg, current) => agg + current);
            Console.WriteLine(answer);

            var alternateAnswer = Enumerable.Range(1, 999).Where(number => (number%5 == 0) || (number%3 == 0)).Sum();
            Console.WriteLine(alternateAnswer);


            Console.ReadLine();

        }
    }
}
