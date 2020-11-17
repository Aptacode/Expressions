using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class MultiplyFloat<TContext> : Multiply<float, TContext>, IExpression<float, TContext>
    {
        public MultiplyFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) : base(lhs, rhs) { }
    }
}