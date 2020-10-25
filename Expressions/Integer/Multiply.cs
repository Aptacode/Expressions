namespace Expressions.Integer
{
    public class Multiply<TContext> : BinaryIntegerExpression<TContext> where TContext : IContext
    {
        public Multiply(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
        public override int Interpret(TContext context) => Lhs.Interpret(context) * Rhs.Interpret(context);
    }
}