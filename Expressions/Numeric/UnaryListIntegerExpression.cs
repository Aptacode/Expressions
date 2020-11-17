using System;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Numeric
{
    public abstract class UnaryListIntegerExpression<TType, TContext> : IExpression<int, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        protected UnaryListIntegerExpression(IListExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TType, TContext> Expression { get; }

        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}