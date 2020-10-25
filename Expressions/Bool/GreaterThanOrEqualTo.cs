using Expressions.Integer;

namespace Expressions.Bool
{
    public class GreaterThanOrEqualTo<TContext> : BinaryBoolExpression<TContext> where TContext : IContext
    {
        public override bool Interpret(TContext context) => Lhs.Interpret(context) >= Rhs.Interpret(context);
        public GreaterThanOrEqualTo(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}