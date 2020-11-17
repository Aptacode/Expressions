using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool
{
    public class ConstantBool<TContext> : ConstantExpression<bool, TContext>
    {
        public ConstantBool(bool value) : base(value) { }
    }
}