using System.Linq;

namespace Aptacode.Expressions.List.ListOperators.Extensions
{
    public static class ListOperatorExtensions
    {
        public static First<TType, TContext> First<TType, TContext>(
            this IListExpression<TType, TContext> expression)
        {
            return new First<TType, TContext>(expression);
        }

        public static Last<TType, TContext> Last<TType, TContext>(
            this IListExpression<TType, TContext> expression)
        {
            return new Last<TType, TContext>(expression);
        }

        public static TakeFirst<TType, TContext> TakeFirst<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            IExpression<int, TContext> count)
        {
            return new TakeFirst<TType, TContext>(expression, count);
        }

        public static TakeLast<TType, TContext> TakeLast<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            IExpression<int, TContext> count)
        {
            return new TakeLast<TType, TContext>(expression, count);
        }

        public static IListExpression<TType, TContext> ConcatList<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            params IListExpression<TType, TContext>[] expressions)

        {
            return expressions.Aggregate(expression,
                (current, listExpression) => new ConcatList<TType, TContext>(current, listExpression));
        }

        public static GetValue<TType, TContext> GetValue<TType, TContext>(
            this IListExpression<TType, TContext> expression,
            IExpression<int, TContext> index)
        {
            return new GetValue<TType, TContext>(expression, index);
        }
    }
}