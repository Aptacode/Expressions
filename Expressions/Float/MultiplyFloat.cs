using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class MultiplyFloat<TContext> : Multiply<float, TContext>, IFloatExpression<TContext>
    {
        public MultiplyFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}