using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class SubtractInteger<TContext> : Subtract<int, TContext>, IExpression<int, TContext>
    {
        public SubtractInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(lhs, rhs) { }
    }
}