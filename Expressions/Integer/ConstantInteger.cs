using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class ConstantInteger<TContext> : ConstantNumericExpression<int, TContext>, IIntegerExpression<TContext>
    {
        public ConstantInteger(int value) : base(value) { }
    }
}