using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class ConstantInteger<TContext> : ConstantNumericExpression<int, TContext>, IExpression<int, TContext>
    {
        public ConstantInteger(int value) : base(value) { }
    }
}