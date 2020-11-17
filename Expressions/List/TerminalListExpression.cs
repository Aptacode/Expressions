using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TerminalListExpression<TType, TContext> : IListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}