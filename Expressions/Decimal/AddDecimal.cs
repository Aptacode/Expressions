using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class AddDecimal<TContext> : Add<decimal, TContext>
    {
        public AddDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}