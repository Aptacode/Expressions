using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class UnaryListExpression<TType, TContext> : IListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected UnaryListExpression(IListExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TType, TContext> Expression { get; }

        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}