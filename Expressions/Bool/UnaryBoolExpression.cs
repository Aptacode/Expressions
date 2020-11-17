using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class UnaryBoolExpression<TContext> : IBooleanExpression<TContext>
    {
        protected UnaryBoolExpression(IBooleanExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IBooleanExpression<TContext> Expression { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}