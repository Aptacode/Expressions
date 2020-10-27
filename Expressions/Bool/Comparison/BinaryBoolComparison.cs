using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.Bool.Comparison
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
    }
}