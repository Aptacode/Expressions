using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class UnaryExpression<TType, TContext> : IExpression<TType, TContext>
    {
        protected UnaryExpression(IExpression<TType, TContext> expression)
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