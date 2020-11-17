using System.Linq;
using Aptacode.Expressions.Bool.Expression;

namespace Aptacode.Expressions.Bool.Extensions
{
    public static class BoolExpressionExtensions
    {
        public static IExpression<bool, TContext> All<TContext>(this IExpression<bool, TContext> expression,
            params IExpression<bool, TContext>[] expressions)
        {
            var allExpressions = expressions.ToList();
            allExpressions.Add(expression);
            return new All<TContext>(allExpressions.ToArray());
        }

        public static IExpression<bool, TContext> Any<TContext>(this IExpression<bool, TContext> expression,
            params IExpression<bool, TContext>[] expressions)
        {
            var allExpressions = expressions.ToList();
            allExpressions.Add(expression);
            return new Any<TContext>(allExpressions.ToArray());
        }

        public static IExpression<bool, TContext> Not<TContext>(this IExpression<bool, TContext> expression)
            => new Not<TContext>(expression);

        public static IExpression<bool, TContext> Or<TContext>(this IExpression<bool, TContext> lhs,
            IExpression<bool, TContext> rhs)
            => new Or<TContext>(lhs, rhs);

        public static IExpression<bool, TContext> And<TContext>(this IExpression<bool, TContext> lhs,
            IExpression<bool, TContext> rhs)
            => new And<TContext>(lhs, rhs);
    }
}