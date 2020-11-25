using System.Linq;

namespace Aptacode.Expressions.List.Extensions
{
    public static class IntegerListOperatorExtensions
    {
        public static Count<TType, TContext> Count<TType, TContext>(
            this IListExpression<TType, TContext> expression)
            =>
                new Count<TType, TContext>(expression);
    }
}