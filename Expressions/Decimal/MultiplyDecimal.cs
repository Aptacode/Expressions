namespace Aptacode.Expressions.Decimal
{
    public class MultiplyDecimal<TContext> : BinaryDecimalExpression<TContext> 
    {
        public MultiplyDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) : base(lhs, rhs) { }
        public override decimal Interpret(TContext context) => Lhs.Interpret(context) * Rhs.Interpret(context);
    }
}