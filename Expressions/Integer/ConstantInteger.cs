using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Integer
{
    public class ConstantInteger<TContext> : ConstantExpression<int, TContext>
    {
        public ConstantInteger(int value) : base(value)
        {
        }
    }
}