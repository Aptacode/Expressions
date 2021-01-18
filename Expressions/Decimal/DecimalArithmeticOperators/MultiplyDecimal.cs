using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Decimal.DecimalArithmeticOperators
{
    public class MultiplyDecimal<TContext> : Multiply<decimal, TContext>
    {
        public MultiplyDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) :
            base(lhs, rhs)
        {
        }
    }
}