using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.String
{
    public class ConstantString<TContext> : ConstantExpression<string, TContext>
    {
        public ConstantString(string value) : base(value) { }
    }
}