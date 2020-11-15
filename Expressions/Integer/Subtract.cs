namespace Aptacode.Expressions.Integer
{
    public class Subtract<TContext> : BinaryIntegerExpression<TContext> 
    {
        public Subtract(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
        public override int Interpret(TContext context) => Lhs.Interpret(context) - Rhs.Interpret(context);
    }
}