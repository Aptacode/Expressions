using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Double
{
    public abstract class BinaryDoubleExpression<TContext> : IDoubleExpression<TContext> 
    {
        protected BinaryDoubleExpression(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IDoubleExpression<TContext> Lhs { get; }

        public IDoubleExpression<TContext> Rhs { get; }

        public abstract double Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}