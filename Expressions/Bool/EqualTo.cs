using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.Bool
{
    public class EqualTo<TContext> : BinaryBoolExpression<TContext> where TContext : IContext
    {
        public override bool Interpret(TContext context) => Lhs.Interpret(context) == Rhs.Interpret(context);
        public EqualTo(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}