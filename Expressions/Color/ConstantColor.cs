using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Color
{
    public class ConstantColor<TContext> : ConstantExpression<System.Drawing.Color, TContext>
    {
        public ConstantColor(System.Drawing.Color value) : base(value) { }
    }
}