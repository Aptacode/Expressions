using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Decimal
{
    public abstract class BinaryDecimalExpression<TContext> : IDecimalExpression<TContext> 
    {
        protected BinaryDecimalExpression(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IDecimalExpression<TContext> Lhs { get; }

        public IDecimalExpression<TContext> Rhs { get; }

        public abstract decimal Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}