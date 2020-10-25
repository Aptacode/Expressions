using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.Bool
{
    public class LessThan<TContext> : BinaryBoolExpression<TContext> where TContext : IContext
    {
        public override bool Interpret(TContext context) => Lhs.Interpret(context) < Rhs.Interpret(context);
        public LessThan(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}