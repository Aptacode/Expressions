using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class UnaryNumericExpression<TType, TContext> : INumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected UnaryNumericExpression(INumericExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public INumericExpression<TType, TContext> Expression { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}