using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class SubtractDouble<TContext> : Subtract<double, TContext>
    {
        public SubtractDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) : base(lhs, rhs) { }
    }
}