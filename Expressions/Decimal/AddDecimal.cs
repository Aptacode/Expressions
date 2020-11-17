namespace Aptacode.Expressions.Decimal
{
    public class AddDecimal<TContext> : BinaryDecimalExpression<TContext> 
    {
        public AddDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) : base(lhs, rhs) { }

        public override decimal Interpret(TContext context) => Lhs.Interpret(context) + Rhs.Interpret(context);
    }
}