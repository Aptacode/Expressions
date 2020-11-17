using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Decimal
{
    public class ConstantDecimal<TContext> : ConstantExpression<decimal, TContext>
    {
        public ConstantDecimal(decimal value) : base(value) { }
    }
}