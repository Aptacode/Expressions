namespace Aptacode.Expressions.Float
{
    public class MultiplyFloat<TContext> : BinaryFloatExpression<TContext> 
    {
        public MultiplyFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) : base(lhs, rhs) { }
        public override float Interpret(TContext context) => Lhs.Interpret(context) * Rhs.Interpret(context);
    }
}