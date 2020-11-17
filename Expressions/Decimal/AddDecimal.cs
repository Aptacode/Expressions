using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class AddDecimal<TContext> : Add<decimal, TContext>
    {
        public AddDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) : base(lhs, rhs) { }
    }
}