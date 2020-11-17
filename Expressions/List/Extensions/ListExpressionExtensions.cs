using System;
using System.Linq;
using Aptacode.Expressions.Numeric;
using Aptacode.Expressions.Numeric.List;

namespace Aptacode.Expressions.List.Extensions
{
    public static class ListExpressionExtensions
    {
        public static INumericExpression<int, TContext> Count<TType, TContext>(
            this IListExpression<TType, TContext> expression) where TType : struct, IConvertible, IEquatable<TType>
            =>
                new Count<TType, TContext>(expression);

        public static UnaryListItemExpression<TType, TContext> First<TType, TContext>(
            this IListExpression<TType, TContext> expression) where TType : struct, IConvertible, IEquatable<TType>
            =>
                new First<TType, TContext>(expression);

        public static UnaryListItemExpression<TType, TContext> Last<TType, TContext>(
            this IListExpression<TType, TContext> expression) where TType : struct, IConvertible, IEquatable<TType>
            =>
                new Last<TType, TContext>(expression);

        public static IListExpression<TType, TContext> TakeFirst<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            INumericExpression<int, TContext> count) where TType : struct, IConvertible, IEquatable<TType>
            =>
                new TakeFirst<TType, TContext>(expression, count);

        public static IListExpression<TType, TContext> TakeLast<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            INumericExpression<int, TContext> count) where TType : struct, IConvertible, IEquatable<TType>
            =>
                new TakeLast<TType, TContext>(expression, count);

        public static IListExpression<TType, TContext> Concat<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            params IListExpression<TType, TContext>[] expressions) where TType : struct, IConvertible, IEquatable<TType>

        {
            return expressions.Aggregate(expression,
                (current, listExpression) => new ConcatList<TType, TContext>(current, listExpression));
        }
    }
}