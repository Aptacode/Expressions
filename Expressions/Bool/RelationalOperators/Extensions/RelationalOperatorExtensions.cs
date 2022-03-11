namespace Aptacode.Expressions.Bool.RelationalOperators.Extensions;

public static class RelationalOperatorExtensions
{
    public static GreaterThan<TType, TContext> GreaterThan<TType, TContext>(
        this IExpression<TType, TContext> lhs,
        IExpression<TType, TContext> rhs)
    {
        return new GreaterThan<TType, TContext>(lhs, rhs);
    }

    public static GreaterThanOrEqualTo<TType, TContext> GreaterThanOrEqualTo<TType, TContext>(
        this IExpression<TType, TContext> lhs,
        IExpression<TType, TContext> rhs)
    {
        return new GreaterThanOrEqualTo<TType, TContext>(lhs, rhs);
    }

    public static LessThan<TType, TContext> LessThan<TType, TContext>(
        this IExpression<TType, TContext> lhs,
        IExpression<TType, TContext> rhs)
    {
        return new LessThan<TType, TContext>(lhs, rhs);
    }

    public static LessThanOrEqualTo<TType, TContext> LessThanOrEqualTo<TType, TContext>(
        this IExpression<TType, TContext> lhs,
        IExpression<TType, TContext> rhs)
    {
        return new LessThanOrEqualTo<TType, TContext>(lhs, rhs);
    }
}