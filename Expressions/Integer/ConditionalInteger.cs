using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class ConditionalInteger<TContext> : ConditionalNumeric<int, TContext>, IExpression<int, TContext>
    {
        public ConditionalInteger(IExpression<bool, TContext> condition, IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(condition, lhs, rhs) { }
    }
}