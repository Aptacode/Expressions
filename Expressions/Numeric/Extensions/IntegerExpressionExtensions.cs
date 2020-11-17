using System;
using System.Linq;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;

namespace Aptacode.Expressions.Numeric.Extensions
{
    public static class IntegerExpressionExtensions
    {
        public static INumericExpression<TType, TContext> Add<TType, TContext>(
            this INumericExpression<TType, TContext> expression,
            params INumericExpression<TType, TContext>[] expressions)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Add<TType, TContext>(current, integerExpression));
        }

        public static INumericExpression<TType, TContext> Subtract<TType, TContext>(
            this INumericExpression<TType, TContext> expression,
            params INumericExpression<TType, TContext>[] expressions)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            return expressions.Aggregate(expression,
                (current, integerExpression) => new Subtract<TType, TContext>(current, integerExpression));
        }

        public static IBooleanExpression<TContext> GreaterThan<TType, TContext>(
            this INumericExpression<TType, TContext> lhs,
            INumericExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new GreaterThan<TType, TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> EqualTo<TType, TContext>(
            this INumericExpression<TType, TContext> lhs,
            INumericExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new EqualTo<TType, TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> GreaterThanOrEqualTo<TType, TContext>(
            this INumericExpression<TType, TContext> lhs,
            INumericExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new GreaterThanOrEqualTo<TType, TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> LessThan<TType, TContext>(
            this INumericExpression<TType, TContext> lhs,
            INumericExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new LessThan<TType, TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> LessThanOrEqualTo<TType, TContext>(
            this INumericExpression<TType, TContext> lhs,
            INumericExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new LessThanOrEqualTo<TType, TContext>(lhs, rhs);
    }
}