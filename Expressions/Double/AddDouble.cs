using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class AddDouble<TContext> : Add<double, TContext>, IDoubleExpression<TContext>
    {
        public AddDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}