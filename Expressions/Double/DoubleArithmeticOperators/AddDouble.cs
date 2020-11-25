using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators
{
    public class AddDouble<TContext> : Add<double, TContext>
    {
        public AddDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) : base(lhs, rhs) { }
    }
}