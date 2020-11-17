using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class ConstantDecimal<TContext> : ConstantNumericExpression<decimal, TContext>, IExpression<decimal, TContext>
    {
        public ConstantDecimal(decimal value) : base(value) { }
    }
}