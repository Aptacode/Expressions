namespace Aptacode.Expressions.Integer
{
    public class Multiply<TContext> : BinaryIntegerExpression<TContext> 
    {
        public Multiply(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
        public override int Interpret(TContext context) => Lhs.Interpret(context) * Rhs.Interpret(context);
    }
}