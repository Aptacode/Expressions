using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class UnaryNumericExpression<TType, TContext> : IExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected UnaryNumericExpression(IExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public IExpression<TType, TContext> Expression { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}