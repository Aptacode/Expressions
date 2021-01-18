using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Integer.IntegerArithmeticOperators
{
    public class SubtractInteger<TContext> : Subtract<int, TContext>
    {
        public SubtractInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}