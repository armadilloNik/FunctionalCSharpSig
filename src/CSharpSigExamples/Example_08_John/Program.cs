using System;
using System.Linq.Expressions;

namespace Example_08_John
{
    class Program
    {
        static void Main(string[] args)
        {
            var lambdaWriter = new LambdaWriter();
            var lambdaModifier = new LambdaModifier();

            Expression<Func<int, int, int>> sumExpression = (x, y) => x + y;

            Console.Write("Original Sum Expression: ");
            lambdaWriter.Visit(sumExpression);

            var modifiedSum = lambdaModifier.Visit(sumExpression);

            Console.Write("Modified Sum Expression: ");
            lambdaWriter.Visit(modifiedSum);

            Expression<Func<int, int, int>> diffExpression = (x, y) => x - y;

            Console.Write("Original Difference Expression: ");
            lambdaWriter.Visit(diffExpression);

            var modifiedDiff = lambdaModifier.Visit(diffExpression);

            Console.Write("Modified Difference Expression: ");
            lambdaWriter.Visit(modifiedDiff);

        }
    }

    public class LambdaWriter : ExpressionVisitor
    {
        protected override Expression VisitLambda<T>(Expression<T> lambda)
        {
            Console.WriteLine("{0} \n", lambda);
            Console.ReadLine();

            return base.VisitLambda(lambda);
        }

    }

    public class LambdaModifier : ExpressionVisitor
    {
        protected override Expression VisitLambda<T>(Expression<T> lambda)
        {
            if (lambda.ToString() == "(x, y) => (x + y)")
            {
                Expression<Func<int, int, int>> prod = (x, y) => x * y;

                return prod;
            }

            return base.VisitLambda(lambda);
        }
    }
}
