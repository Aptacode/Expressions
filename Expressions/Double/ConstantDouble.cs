using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Double
{
    public class ConstantDouble<TContext> : ConstantExpression<double, TContext>
    {
        public ConstantDouble(double value) : base(value) { }
    }
}