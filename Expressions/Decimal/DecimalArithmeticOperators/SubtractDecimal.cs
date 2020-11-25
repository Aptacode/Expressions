using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Decimal.DecimalArithmeticOperators
{
    public class SubtractDecimal<TContext> : Subtract<decimal, TContext>
    {
        public SubtractDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) :
            base(lhs, rhs) { }
    }
}