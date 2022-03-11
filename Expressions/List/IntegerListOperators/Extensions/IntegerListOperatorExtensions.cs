namespace Aptacode.Expressions.List.IntegerListOperators.Extensions;

public static class IntegerListOperatorExtensions
{
    public static Count<TType, TContext> Count<TType, TContext>(
        this IListExpression<TType, TContext> expression)
    {
        return new Count<TType, TContext>(expression);
    }
}