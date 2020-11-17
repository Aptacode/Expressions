using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class UnaryBoolExpression<TContext> : IExpression<bool, TContext>
    {
        protected UnaryBoolExpression(IExpression<bool, TContext> expression)
        {
            Expression = expression;
        }

        public IExpression<bool, TContext> Expression { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}