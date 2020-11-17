using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class MultiplyInteger<TContext> : Multiply<int, TContext>, IIntegerExpression<TContext>
    {
        public MultiplyInteger(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}