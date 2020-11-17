using System;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TernaryListExpression<TType, TContext> : IListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected TernaryListExpression(IBooleanExpression<TContext> condition,
            IListExpression<TType, TContext> passExpression, IListExpression<TType, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IListExpression<TType, TContext> PassExpression { get; }

        public IListExpression<TType, TContext> FailExpression { get; }

        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}