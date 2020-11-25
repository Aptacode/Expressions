using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class AddFloat<TContext> : Add<float, TContext>
    {
        public AddFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) : base(lhs, rhs) { }
    }
}