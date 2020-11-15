﻿using System.Linq;
using Aptacode.Expressions.Bool.Expression;

namespace Aptacode.Expressions.Bool.Extensions
{
    public static class BoolExpressionExtensions
    {
        public static IBooleanExpression<TContext> All<TContext>(this IBooleanExpression<TContext> expression,
            params IBooleanExpression<TContext>[] expressions)
        {
            var allExpressions = expressions.ToList();
            allExpressions.Add(expression);
            return new All<TContext>(allExpressions.ToArray());
        }

        public static IBooleanExpression<TContext> Any<TContext>(this IBooleanExpression<TContext> expression,
            params IBooleanExpression<TContext>[] expressions)
        {
            var allExpressions = expressions.ToList();
            allExpressions.Add(expression);
            return new Any<TContext>(allExpressions.ToArray());
        }

        public static IBooleanExpression<TContext> Not<TContext>(this IBooleanExpression<TContext> expression)
             => new Not<TContext>(expression);

        public static IBooleanExpression<TContext> Or<TContext>(this IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs)
     => new Or<TContext>(lhs, rhs);

        public static IBooleanExpression<TContext> And<TContext>(this IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs)
     => new And<TContext>(lhs, rhs);
    }
}