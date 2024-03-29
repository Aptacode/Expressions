﻿using System.Linq;

namespace Aptacode.Expressions.List.ListOperators;

/// <summary>
///     The class for the operation of getting the last expression in a list expression.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record Last<TType, TContext>
    (IListExpression<TType, TContext> Expression) : UnaryListItemExpression<TType, TContext>(Expression)

{
    public override TType Interpret(TContext context)
    {
        var list = Expression.Interpret(context);
        return list.Length != 0 ? list.Last() : default;
    }
}