using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class UnaryListIntegerExpression<TType, TContext> : IExpression<int, TContext>

    {
        protected UnaryListIntegerExpression(IListExpression<TType, TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TType, TContext> Expression { get; }

        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}