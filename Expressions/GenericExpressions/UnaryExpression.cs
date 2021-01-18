using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class UnaryExpression<TType, TContext> : IExpression<TType, TContext>
    {
        public readonly IExpression<TType, TContext> Expression;

        protected UnaryExpression(IExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}