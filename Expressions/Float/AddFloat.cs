using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class AddFloat<TContext> : Add<float, TContext>
    {
        public AddFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}