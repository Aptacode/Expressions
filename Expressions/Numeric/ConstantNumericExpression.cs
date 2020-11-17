using System;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public class ConstantNumericExpression<TType, TContext> : ITerminalNumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected ConstantNumericExpression(TType value)
        {
            Value = value;
        }

        public TType Value { get; }

        public TType Interpret(TContext context) => Value;

        public void Visit(IExpressionVisitor<TContext> visitor) => visitor.Visit(this);
    }
}