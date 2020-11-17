using System;
using Aptacode.Expressions.Numeric;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool.Comparison
{
    public abstract class BinaryBoolComparison<TType, TContext> : IBooleanExpression<TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected BinaryBoolComparison(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<TType, TContext> Lhs { get; }

        public IExpression<TType, TContext> Rhs { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}