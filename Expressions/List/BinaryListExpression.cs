using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class BinaryListExpression<TType, TContext> : IListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected BinaryListExpression(IListExpression<TType, TContext> lhs, IListExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IListExpression<TType, TContext> Lhs { get; }

        public IListExpression<TType, TContext> Rhs { get; }

        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}