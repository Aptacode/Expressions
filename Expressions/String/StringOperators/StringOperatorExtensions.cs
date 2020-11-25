using System.Linq;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class StringOperatorExtensions
    {
        public static IExpression<string, TContext> ConcatString<TContext>(
            this IExpression<string, TContext> stringExpression,
            params IExpression<string, TContext>[] stringExpressions)

        {
            return stringExpressions.Aggregate(stringExpression,
                (current, aggregateExpression) => new Add<string, TContext>(current, aggregateExpression));
        }
    }
}