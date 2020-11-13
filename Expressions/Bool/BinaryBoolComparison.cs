using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class BinaryBoolComparison<TContext> : IBooleanExpression<TContext> where TContext : IContext
    {
        protected BinaryBoolComparison(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IIntegerExpression<TContext> Lhs { get; }

        public IIntegerExpression<TContext> Rhs { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}