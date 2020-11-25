using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Integer.IntegerArithmeticOperators
{
    public class AddInteger<TContext> : Add<int, TContext>
    {
        public AddInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(lhs, rhs) { }
    }
}