using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Integer
{
    public abstract class UnaryIntegerExpression<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        protected UnaryIntegerExpression(IIntegerExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IIntegerExpression<TContext> Expression { get; }

        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}