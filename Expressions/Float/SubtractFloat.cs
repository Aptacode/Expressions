namespace Aptacode.Expressions.Float
{
    public class SubtractFloat<TContext> : BinaryFloatExpression<TContext> 
    {
        public SubtractFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) : base(lhs, rhs) { }
        public override float Interpret(TContext context) => Lhs.Interpret(context) - Rhs.Interpret(context);
    }
}