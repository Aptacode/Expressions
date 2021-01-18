using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Decimal.DecimalArithmeticOperators
{
    public class AddDecimal<TContext> : Add<decimal, TContext>
    {
        public AddDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}