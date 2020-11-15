using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class BinaryBoolExpression<TContext> : IBooleanExpression<TContext>
    {
        protected BinaryBoolExpression(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IBooleanExpression<TContext> Lhs { get; }

        public IBooleanExpression<TContext> Rhs { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}