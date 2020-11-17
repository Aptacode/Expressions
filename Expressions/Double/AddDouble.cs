using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class AddDouble<TContext> : Add<double, TContext>, IExpression<double, TContext>
    {
        public AddDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) : base(lhs, rhs) { }
    }
}