using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Color
{
    public abstract class BinaryColorExpression<TContext> : IExpression<System.Drawing.Color, TContext>
    {
        protected BinaryColorExpression(IExpression<System.Drawing.Color, TContext> lhs, IExpression<System.Drawing.Color, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<System.Drawing.Color, TContext> Lhs { get; }

        public IExpression<System.Drawing.Color, TContext> Rhs { get; }

        public abstract System.Drawing.Color Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}