using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class UnaryListItemExpression<TType, TContext> : IExpression<TType, TContext>

    {
        protected UnaryListItemExpression(IListExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TType, TContext> Expression { get; }

        public abstract bool Equals(IExpression<TType, TContext> other);
        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}