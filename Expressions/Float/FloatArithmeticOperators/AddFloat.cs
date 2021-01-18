using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Float.FloatArithmeticOperators
{
    public class AddFloat<TContext> : Add<float, TContext>
    {
        public AddFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}