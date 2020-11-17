namespace Aptacode.Expressions.Decimal
{
    public class ConstantDecimal<TContext> : TerminalDecimalExpression<TContext> 
    {
        public ConstantDecimal(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; }

        public override decimal Interpret(TContext context) => Value;
    }
}