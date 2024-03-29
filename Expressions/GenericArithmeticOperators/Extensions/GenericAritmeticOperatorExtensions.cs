﻿using System.Linq;

namespace Aptacode.Expressions.GenericArithmeticOperators.Extensions;

public static class GenericArithmeticOperatorExtensions
{
    public static IExpression<TType, TContext> Add<TType, TContext>(
        this IExpression<TType, TContext> expression,
        params IExpression<TType, TContext>[] expressions)

    {
        return expressions.Aggregate(expression,
            (current, aggregateExpression) => new Add<TType, TContext>(current, aggregateExpression));
    }

    public static IExpression<TType, TContext> Subtract<TType, TContext>(
        this IExpression<TType, TContext> expression,
        params IExpression<TType, TContext>[] expressions)

    {
        return expressions.Aggregate(expression,
            (current, aggregateExpression) => new Subtract<TType, TContext>(current, aggregateExpression));
    }

    public static IExpression<TType, TContext> Multiply<TType, TContext>(
        this IExpression<TType, TContext> expression,
        params IExpression<TType, TContext>[] expressions)

    {
        return expressions.Aggregate(expression,
            (current, aggregateExpression) => new Multiply<TType, TContext>(current, aggregateExpression));
    }
}