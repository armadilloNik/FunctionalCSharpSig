using System;
using System.Linq;
using System.Linq.Expressions;

namespace Example_07_Sara
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> sumExpression = (x, y) => x + y;

            var lambdaWriter = new LambdaWriter();
            lambdaWriter.Visit(sumExpression);

            //var compiledExpression = sumExpression.Compile();
            //var sum = compiledExpression(1, 2);

            //Console.WriteLine("\nSum: {0}", sum);

            Console.ReadLine();

        }
    }

    public class LambdaWriter : ExpressionVisitor
    {
        protected override Expression VisitLambda<T>(Expression<T> lambda)
        {
            Console.WriteLine("Lambda Expression: {0}", lambda);

            lambda.Parameters.ToList().ForEach(param => Console.WriteLine("Parameter: {0}", param));

            Console.WriteLine("Lambda Expression Body: {0}", lambda.Body);
            Console.WriteLine("Lambda Expression Return Type: {0}", lambda.ReturnType);

            return base.VisitLambda(lambda);
        }

    }
}
