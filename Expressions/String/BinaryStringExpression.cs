using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.String
{
    public abstract class BinaryStringExpression<TContext> : IExpression<string, TContext>
    {
        protected BinaryStringExpression(IExpression<string, TContext> lhs, IExpression<string, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<string, TContext> Lhs { get; }

        public IExpression<string, TContext> Rhs { get; }

        public abstract string Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}