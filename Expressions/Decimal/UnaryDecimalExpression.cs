using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Decimal
{
    public abstract class UnaryDecimalExpression<TContext> : IDecimalExpression<TContext>
    {
        protected UnaryDecimalExpression(IDecimalExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IDecimalExpression<TContext> Expression { get; }

        public abstract decimal Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}