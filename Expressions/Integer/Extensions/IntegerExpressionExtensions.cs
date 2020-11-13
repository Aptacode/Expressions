using System.Linq;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;

namespace Aptacode.Expressions.Integer.Extensions
{
    public static class IntegerExpressionExtensions
    {
        public static IIntegerExpression<TContext> Add<TContext>(this IIntegerExpression<TContext> expression,
            params IIntegerExpression<TContext>[] expressions) where TContext : IContext
        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Add<TContext>(current, integerExpression));
        }

        public static IIntegerExpression<TContext> Subtract<TContext>(this IIntegerExpression<TContext> expression,
            params IIntegerExpression<TContext>[] expressions) where TContext : IContext
        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Subtract<TContext>(current, integerExpression));
        }

        public static IBooleanExpression<TContext> GreaterThan<TContext>(this IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) where TContext : IContext => new GreaterThan<TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> EqualTo<TContext>(this IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) where TContext : IContext => new EqualTo<TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> GreaterThanOrEqualTo<TContext>(this IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) where TContext : IContext => new GreaterThanOrEqualTo<TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> LessThan<TContext>(this IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) where TContext : IContext => new LessThan<TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> LessThanOrEqualTo<TContext>(this IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) where TContext : IContext => new LessThanOrEqualTo<TContext>(lhs, rhs);
    }
}