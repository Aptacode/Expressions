using System;
using System.Linq;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class IntegerExpressionExtensions
    {
        public static IExpression<TType, TContext> Add<TType, TContext>(
            this IExpression<TType, TContext> expression,
            params IExpression<TType, TContext>[] expressions)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Add<TType, TContext>(current, integerExpression));
        }

        public static IExpression<TType, TContext> Subtract<TType, TContext>(
            this IExpression<TType, TContext> expression,
            params IExpression<TType, TContext>[] expressions)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Subtract<TType, TContext>(current, integerExpression));
        }

        public static GreaterThan<TType, TContext> GreaterThan<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new GreaterThan<TType, TContext>(lhs, rhs);

        public static EqualTo<TType, TContext> EqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new EqualTo<TType, TContext>(lhs, rhs);

        public static GreaterThanOrEqualTo<TType, TContext> GreaterThanOrEqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new GreaterThanOrEqualTo<TType, TContext>(lhs, rhs);

        public static LessThan<TType, TContext> LessThan<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new LessThan<TType, TContext>(lhs, rhs);

        public static LessThanOrEqualTo<TType, TContext> LessThanOrEqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new LessThanOrEqualTo<TType, TContext>(lhs, rhs);
    }
}