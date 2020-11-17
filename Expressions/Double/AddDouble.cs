namespace Aptacode.Expressions.Double
{
    public class AddDouble<TContext> : BinaryDoubleExpression<TContext> 
    {
        public AddDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) : base(lhs, rhs) { }

        public override double Interpret(TContext context) => Lhs.Interpret(context) + Rhs.Interpret(context);
    }
}