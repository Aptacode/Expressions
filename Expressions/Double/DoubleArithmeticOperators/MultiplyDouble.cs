using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators
{
    public class MultiplyDouble<TContext> : Multiply<double, TContext>
    {
        public MultiplyDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}