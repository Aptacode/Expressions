﻿using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TerminalListExpression<TType, TContext> : IListExpression<TType, TContext>

    {
        public abstract bool Equals(IExpression<TType[], TContext> other);
        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}