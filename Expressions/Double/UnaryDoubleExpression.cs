using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Double
{
    public abstract class UnaryDoubleExpression<TContext> : IDoubleExpression<TContext>
    {
        protected UnaryDoubleExpression(IDoubleExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IDoubleExpression<TContext> Expression { get; }

        public abstract double Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}