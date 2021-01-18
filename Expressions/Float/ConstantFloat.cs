using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Float
{
    public class ConstantFloat<TContext> : ConstantExpression<float, TContext>
    {
        public ConstantFloat(float value) : base(value)
        {
        }
    }
}