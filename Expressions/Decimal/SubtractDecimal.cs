using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class SubtractDecimal<TContext> : Subtract<decimal, TContext>
    {
        public SubtractDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) :
            base(lhs, rhs) { }
    }
}