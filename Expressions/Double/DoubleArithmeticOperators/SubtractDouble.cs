using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators
{
    public class SubtractDouble<TContext> : Subtract<double, TContext>
    {
        public SubtractDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}