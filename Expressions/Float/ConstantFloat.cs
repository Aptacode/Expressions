using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class ConstantFloat<TContext> : ConstantNumericExpression<float, TContext>, IFloatExpression<TContext>
    {
        public ConstantFloat(float value) : base(value) { }
    }
}