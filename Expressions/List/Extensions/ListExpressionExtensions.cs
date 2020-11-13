using System.Linq;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Integer.List;

namespace Aptacode.Expressions.List.Extensions
{
    public static class ListExpressionExtensions
    {
        public static IIntegerExpression<TContext> Count<TContext>(this IListExpression<TContext> expression)
            where TContext : IContext =>
            new Count<TContext>(expression);

        public static IIntegerExpression<TContext> First<TContext>(this IListExpression<TContext> expression)
            where TContext : IContext =>
            new First<TContext>(expression);

        public static IIntegerExpression<TContext> Last<TContext>(this IListExpression<TContext> expression)
            where TContext : IContext =>
            new Last<TContext>(expression);

        public static IListExpression<TContext> TakeFirst<TContext>(this IListExpression<TContext> expression,
            IIntegerExpression<TContext> count)
            where TContext : IContext =>
            new TakeFirst<TContext>(expression, count);

        public static IListExpression<TContext> TakeLast<TContext>(this IListExpression<TContext> expression,
            IIntegerExpression<TContext> count)
            where TContext : IContext =>
            new TakeLast<TContext>(expression, count);

        public static IListExpression<TContext> Concat<TContext>(this IListExpression<TContext> expression,
            params IListExpression<TContext>[] expressions)
            where TContext : IContext
        {
            return expressions.Aggregate(expression,
                (current, listExpression) => new ConcatList<TContext>(current, listExpression));
        }
    }
}