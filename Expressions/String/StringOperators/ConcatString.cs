using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.String.StringOperators
{
    public class ConcatString<TContext> : Add<string, TContext>
    {
        public ConcatString(IExpression<string, TContext> lhs, IExpression<string, TContext> rhs) : base(lhs, rhs)
        {
        }
    }
}