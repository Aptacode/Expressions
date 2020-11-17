namespace Aptacode.Expressions.Double
{
    public class MultiplyDouble<TContext> : BinaryDoubleExpression<TContext> 
    {
        public MultiplyDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) : base(lhs, rhs) { }
        public override double Interpret(TContext context) => Lhs.Interpret(context) * Rhs.Interpret(context);
    }
}