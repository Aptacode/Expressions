using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class UnaryListExpression<TType, TContext> : IListExpression<TType, TContext>

    {
        protected UnaryListExpression(IListExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TType, TContext> Expression { get; }

        public abstract bool Equals(IExpression<TType[], TContext> other);
        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}