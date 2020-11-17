using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class BinaryNumericExpression<TType, TContext> : INumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected BinaryNumericExpression(INumericExpression<TType, TContext> lhs,
            INumericExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public INumericExpression<TType, TContext> Lhs { get; }

        public INumericExpression<TType, TContext> Rhs { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}