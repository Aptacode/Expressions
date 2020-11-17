using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Double
{
    public class ConstantDouble<TContext> : ConstantNumericExpression<double, TContext>, IExpression<double, TContext>
    {
        public ConstantDouble(double value) : base(value) { }
    }
}