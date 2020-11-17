using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class SubtractInteger<TContext> : Subtract<int, TContext>
    {
        public SubtractInteger(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}