using Aptacode.Expressions.GenericArithmeticOperators;
using System.Linq;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class FloatArithmeticOperatorExtensions
    {
        public static IExpression<float, TContext> AddFloat<TContext>(
            this IExpression<float, TContext> floatExpression,
            params IExpression<float, TContext>[] floatExpressions)

        {
            return floatExpressions.Aggregate(floatExpression,
                (current, aggregateExpression) => new Add<float, TContext>(current, aggregateExpression));
        }

        public static IExpression<float, TContext> SubtractFloat<TContext>(
        this IExpression<float, TContext> floatExpression,
        params IExpression<float, TContext>[] floatExpressions)

        {
            return floatExpressions.Aggregate(floatExpression,
                (current, aggregateExpression) => new Subtract<float, TContext>(current, aggregateExpression));
        }


        public static IExpression<float, TContext> MultiplyFloat<TContext>(
        this IExpression<float, TContext> floatExpression,
        params IExpression<float, TContext>[] floatExpressions)

        {
            return floatExpressions.Aggregate(floatExpression,
                (current, aggregateExpression) => new Multiply<float, TContext>(current, aggregateExpression));
        }

    }
}