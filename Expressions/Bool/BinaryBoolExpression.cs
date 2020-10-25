using Expressions.Integer;

namespace Expressions.Bool
{
    public abstract class BinaryBoolExpression<TContext> : IBooleanExpression<TContext> where TContext : IContext
    {
        protected BinaryBoolExpression(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }
        public IIntegerExpression<TContext> Lhs { get; }

        public IIntegerExpression<TContext> Rhs { get; }

        public abstract bool Interpret(TContext context);
    }
}