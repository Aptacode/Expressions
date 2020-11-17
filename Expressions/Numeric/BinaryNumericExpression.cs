using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class BinaryNumericExpression<TType, TContext> : IExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected BinaryNumericExpression(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<TType, TContext> Lhs { get; }

        public IExpression<TType, TContext> Rhs { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}