using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Decimal
{
    public class MultiplyDecimal<TContext> : Multiply<decimal, TContext>, IExpression<decimal, TContext>
    {
        public MultiplyDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) : base(lhs, rhs) { }
    }
}