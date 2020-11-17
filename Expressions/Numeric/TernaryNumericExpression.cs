using System;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class TernaryNumericExpression<TType, TContext> : INumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected TernaryNumericExpression(IBooleanExpression<TContext> condition,
            INumericExpression<TType, TContext> passExpression, INumericExpression<TType, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public INumericExpression<TType, TContext> PassExpression { get; }

        public INumericExpression<TType, TContext> FailExpression { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}