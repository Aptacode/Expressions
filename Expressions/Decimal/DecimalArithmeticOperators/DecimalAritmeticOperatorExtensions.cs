using Aptacode.Expressions.GenericArithmeticOperators;
using System.Linq;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class DecimalArithmeticOperatorExtensions
    {
        public static IExpression<decimal, TContext> AddDecimal<TContext>(
            this IExpression<decimal, TContext> decimalExpression,
            params IExpression<decimal, TContext>[] decimalExpressions)

        {
            return decimalExpressions.Aggregate(decimalExpression,
                (current, aggregateExpression) => new Add<decimal, TContext>(current, aggregateExpression));
        }

        public static IExpression<decimal, TContext> SubtractDecimal<TContext>(
        this IExpression<decimal, TContext> decimalExpression,
        params IExpression<decimal, TContext>[] decimalExpressions)

        {
            return decimalExpressions.Aggregate(decimalExpression,
                (current, aggregateExpression) => new Subtract<decimal, TContext>(current, aggregateExpression));
        }


        public static IExpression<decimal, TContext> MultiplyDecimal<TContext>(
        this IExpression<decimal, TContext> decimalExpression,
        params IExpression<decimal, TContext>[] decimalExpressions)

        {
            return decimalExpressions.Aggregate(decimalExpression,
                (current, aggregateExpression) => new Multiply<decimal, TContext>(current, aggregateExpression));
        }
    }
}