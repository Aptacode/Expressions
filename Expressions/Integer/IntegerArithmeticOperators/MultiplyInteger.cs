using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Integer.IntegerArithmeticOperators
{
    public class MultiplyInteger<TContext> : Multiply<int, TContext>
    {
        public MultiplyInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}