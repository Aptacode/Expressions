using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class BinaryBoolExpression<TContext> : IExpression<bool, TContext>
    {
        protected BinaryBoolExpression(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<bool, TContext> Lhs { get; }

        public IExpression<bool, TContext> Rhs { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}