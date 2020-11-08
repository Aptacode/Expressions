﻿namespace Aptacode.Expressions.Guid
{
    public abstract class BinaryGuidExpression<TContext> : IGuidExpression<TContext> where TContext : IContext
    {
        protected BinaryGuidExpression(IGuidExpression<TContext> lhs, IGuidExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IGuidExpression<TContext> Lhs { get; }

        public IGuidExpression<TContext> Rhs { get; }

        public abstract System.Guid Interpret(TContext context);
    }
}