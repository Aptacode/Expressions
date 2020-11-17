using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class SubtractDouble<TContext> : Subtract<double, TContext>, IDoubleExpression<TContext>
    {
        public SubtractDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}