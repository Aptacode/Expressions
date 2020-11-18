using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.String
{
    public class ConcatString<TContext> : Add<string, TContext>
    {
        public ConcatString(IExpression<string, TContext> lhs, IExpression<string, TContext> rhs) : base(lhs, rhs) { }
    }
}