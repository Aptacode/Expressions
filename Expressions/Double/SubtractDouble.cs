namespace Aptacode.Expressions.Double
{
    public class SubtractDouble<TContext> : BinaryDoubleExpression<TContext> 
    {
        public SubtractDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) : base(lhs, rhs) { }
        public override double Interpret(TContext context) => Lhs.Interpret(context) - Rhs.Interpret(context);
    }
}