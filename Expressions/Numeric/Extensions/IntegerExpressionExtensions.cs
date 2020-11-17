using System.Linq;
using Aptacode.Expressions.Bool.Comparison;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class IntegerExpressionExtensions
    {
        public static IExpression<TType, TContext> Add<TType, TContext>(
            this IExpression<TType, TContext> expression,
            params IExpression<TType, TContext>[] expressions)

        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Add<TType, TContext>(current, integerExpression));
        }

        public static IExpression<TType, TContext> Subtract<TType, TContext>(
            this IExpression<TType, TContext> expression,
            params IExpression<TType, TContext>[] expressions)

        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Subtract<TType, TContext>(current, integerExpression));
        }

        public static GreaterThan<TType, TContext> GreaterThan<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new GreaterThan<TType, TContext>(lhs, rhs);

        public static EqualTo<TType, TContext> EqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new EqualTo<TType, TContext>(lhs, rhs);

        public static GreaterThanOrEqualTo<TType, TContext> GreaterThanOrEqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new GreaterThanOrEqualTo<TType, TContext>(lhs, rhs);

        public static LessThan<TType, TContext> LessThan<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new LessThan<TType, TContext>(lhs, rhs);

        public static LessThanOrEqualTo<TType, TContext> LessThanOrEqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new LessThanOrEqualTo<TType, TContext>(lhs, rhs);
    }
}