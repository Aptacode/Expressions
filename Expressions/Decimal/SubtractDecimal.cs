using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class SubtractDecimal<TContext> : Subtract<decimal, TContext>, IDecimalExpression<TContext>
    {
        public SubtractDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}