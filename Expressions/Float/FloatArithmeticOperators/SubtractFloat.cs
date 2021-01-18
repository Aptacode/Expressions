using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Float.FloatArithmeticOperators
{
    public class SubtractFloat<TContext> : Subtract<float, TContext>
    {
        public SubtractFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}