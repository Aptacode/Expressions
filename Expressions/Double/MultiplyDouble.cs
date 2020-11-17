using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class MultiplyDouble<TContext> : Multiply<double, TContext>, IExpression<double, TContext>
    {
        public MultiplyDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) : base(lhs, rhs) { }
    }
}