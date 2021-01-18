using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class BinaryExpression<TType, TContext> : IExpression<TType, TContext>
    {
        public readonly IExpression<TType, TContext> Lhs;

        public readonly IExpression<TType, TContext> Rhs;

        protected BinaryExpression(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}