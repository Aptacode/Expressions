﻿namespace Aptacode.Expressions.Color
{
    public abstract class BinaryColorExpression<TContext> : IColorExpression<TContext> where TContext : IContext
    {
        protected BinaryColorExpression(IColorExpression<TContext> lhs, IColorExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IColorExpression<TContext> Lhs { get; }

        public IColorExpression<TContext> Rhs { get; }

        public abstract System.Drawing.Color Interpret(TContext context);
    }
}