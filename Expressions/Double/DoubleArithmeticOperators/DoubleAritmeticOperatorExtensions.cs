using System.Linq;
using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators;

public static class DoubleArithmeticOperatorExtensions
{
    public static IExpression<double, TContext> AddDouble<TContext>(
        this IExpression<double, TContext> doubleExpression,
        params IExpression<double, TContext>[] doubleExpressions)

    {
        return doubleExpressions.Aggregate(doubleExpression,
            (current, aggregateExpression) => new Add<double, TContext>(current, aggregateExpression));
    }

    public static IExpression<double, TContext> SubtractDouble<TContext>(
        this IExpression<double, TContext> doubleExpression,
        params IExpression<double, TContext>[] doubleExpressions)

    {
        return doubleExpressions.Aggregate(doubleExpression,
            (current, aggregateExpression) => new Subtract<double, TContext>(current, aggregateExpression));
    }


    public static IExpression<double, TContext> MultiplyDouble<TContext>(
        this IExpression<double, TContext> doubleExpression,
        params IExpression<double, TContext>[] doubleExpressions)

    {
        return doubleExpressions.Aggregate(doubleExpression,
            (current, aggregateExpression) => new Multiply<double, TContext>(current, aggregateExpression));
    }
}