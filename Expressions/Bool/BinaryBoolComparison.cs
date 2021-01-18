using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class BinaryBoolComparison<TType, TContext> : IExpression<bool, TContext>
    {
        public readonly IExpression<TType, TContext> Lhs;

        public readonly IExpression<TType, TContext> Rhs;

        protected BinaryBoolComparison(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}