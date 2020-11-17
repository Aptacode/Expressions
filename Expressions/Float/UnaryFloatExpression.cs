using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Float
{
    public abstract class UnaryFloatExpression<TContext> : IFloatExpression<TContext>
    {
        protected UnaryFloatExpression(IFloatExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IFloatExpression<TContext> Expression { get; }

        public abstract float Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}