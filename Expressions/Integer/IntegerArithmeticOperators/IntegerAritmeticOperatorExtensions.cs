using System.Linq;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class IntegerArithmeticOperatorExtensions
    {
        public static IExpression<int, TContext> AddInteger<TContext>(
            this IExpression<int, TContext> integerExpression,
            params IExpression<int, TContext>[] integerExpressions)

        {
            return integerExpressions.Aggregate(integerExpression,
                (current, aggregateExpression) => new Add<int, TContext>(current, aggregateExpression));
        }

        public static IExpression<int, TContext> SubtracInteger<TContext>(
        this IExpression<int, TContext> integerExpression,
        params IExpression<int, TContext>[] integerExpressions)

        {
            return integerExpressions.Aggregate(integerExpression,
                (current, aggregateExpression) => new Subtract<int, TContext>(current, aggregateExpression));
        }


        public static IExpression<int, TContext> MultiplyInteger<TContext>(
        this IExpression<int, TContext> integerExpression,
        params IExpression<int, TContext>[] integerExpressions)

        {
            return integerExpressions.Aggregate(integerExpression,
                (current, aggregateExpression) => new Multiply<int, TContext>(current, aggregateExpression));
        }
    }
}