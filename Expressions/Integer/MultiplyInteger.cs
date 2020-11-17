using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class MultiplyInteger<TContext> : Multiply<int, TContext>, IExpression<int, TContext>
    {
        public MultiplyInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(lhs, rhs) { }
    }
}