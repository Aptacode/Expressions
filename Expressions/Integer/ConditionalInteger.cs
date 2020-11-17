using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class ConditionalInteger<TContext> : ConditionalNumeric<int, TContext>, IIntegerExpression<TContext>
    {
        public ConditionalInteger(IBooleanExpression<TContext> condition, IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(condition, lhs, rhs) { }
    }
}