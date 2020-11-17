using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class MultiplyDecimal<TContext> : Multiply<decimal, TContext>, IDecimalExpression<TContext>
    {
        public MultiplyDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}