namespace Aptacode.Expressions.Decimal
{
    public class SubtractDecimal<TContext> : BinaryDecimalExpression<TContext> 
    {
        public SubtractDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) : base(lhs, rhs) { }
        public override decimal Interpret(TContext context) => Lhs.Interpret(context) - Rhs.Interpret(context);
    }
}