using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class SubtractFloat<TContext> : Subtract<float, TContext>
    {
        public SubtractFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) : base(lhs, rhs) { }
    }
}