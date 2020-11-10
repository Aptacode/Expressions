using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class BinaryListExpression<TContext> : IListExpression<TContext> where TContext : IContext
    {
        protected BinaryListExpression(IListExpression<TContext> lhs, IListExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IListExpression<TContext> Lhs { get; }

        public IListExpression<TContext> Rhs { get; }

        public abstract int[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}