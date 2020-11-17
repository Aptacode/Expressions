using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class SubtractFloat<TContext> : Subtract<float, TContext>
    {
        public SubtractFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}