using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class BinaryExpression<TType, TContext> : IExpression<TType, TContext>
    {
        protected BinaryExpression(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<TType, TContext> Lhs { get; }

        public IExpression<TType, TContext> Rhs { get; }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}