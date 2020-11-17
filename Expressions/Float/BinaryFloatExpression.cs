using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Float
{
    public abstract class BinaryFloatExpression<TContext> : IFloatExpression<TContext> 
    {
        protected BinaryFloatExpression(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IFloatExpression<TContext> Lhs { get; }

        public IFloatExpression<TContext> Rhs { get; }

        public abstract float Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}