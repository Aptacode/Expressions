using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Guid
{
    public abstract class BinaryGuidExpression<TContext> : IExpression<System.Guid, TContext>
    {
        protected BinaryGuidExpression(IExpression<System.Guid, TContext> lhs, IExpression<System.Guid, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IExpression<System.Guid, TContext> Lhs { get; }

        public IExpression<System.Guid, TContext> Rhs { get; }

        public abstract System.Guid Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}