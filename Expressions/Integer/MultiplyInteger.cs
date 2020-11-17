using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class MultiplyInteger<TContext> : Multiply<int, TContext>
    {
        public MultiplyInteger(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}