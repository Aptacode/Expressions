﻿namespace Expressions.Integer
{
    public abstract class BinaryIntegerExpression<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        protected BinaryIntegerExpression(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }
        public IIntegerExpression<TContext> Lhs { get; }

        public IIntegerExpression<TContext> Rhs { get; }

        public abstract int Interpret(TContext context);
    }
}