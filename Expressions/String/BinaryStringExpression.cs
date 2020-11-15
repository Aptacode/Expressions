using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.String
{
    public abstract class BinaryStringExpression<TContext> : IStringExpression<TContext> 
    {
        protected BinaryStringExpression(IStringExpression<TContext> lhs, IStringExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IStringExpression<TContext> Lhs { get; }

        public IStringExpression<TContext> Rhs { get; }

        public abstract string Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}