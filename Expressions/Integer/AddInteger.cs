using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class AddInteger<TContext> : Add<int, TContext>, IIntegerExpression<TContext>
    {
        public AddInteger(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}