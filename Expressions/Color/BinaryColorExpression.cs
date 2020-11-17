using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Color
{
    public abstract class BinaryColorExpression<TContext> : IColorExpression<TContext>
    {
        protected BinaryColorExpression(IColorExpression<TContext> lhs, IColorExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IColorExpression<TContext> Lhs { get; }

        public IColorExpression<TContext> Rhs { get; }

        public abstract System.Drawing.Color Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}