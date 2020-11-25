using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Float.FloatArithmeticOperators
{
    public class MultiplyFloat<TContext> : Multiply<float, TContext>
    {
        public MultiplyFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) : base(lhs, rhs) { }
    }
}