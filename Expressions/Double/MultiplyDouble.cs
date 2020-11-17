using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class MultiplyDouble<TContext> : Multiply<double, TContext>
    {
        public MultiplyDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}