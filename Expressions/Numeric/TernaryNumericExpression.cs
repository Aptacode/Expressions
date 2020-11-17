using System;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class TernaryNumericExpression<TType, TContext> : IExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected TernaryNumericExpression(IExpression<bool, TContext> condition,
            IExpression<TType, TContext> passExpression, IExpression<TType, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<bool, TContext> Condition { get; }

        public IExpression<TType, TContext> PassExpression { get; }

        public IExpression<TType, TContext> FailExpression { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}