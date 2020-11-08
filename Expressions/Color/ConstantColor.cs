using Aptacode.Expressions.String;

namespace Aptacode.Expressions.Color
{
    public class ConstantColor<TContext> : IColorExpression<TContext> where TContext : IContext
    {
        public ConstantColor(System.Drawing.Color value)
        {
            Value = value;
        }

        public System.Drawing.Color Value { get; }

        public System.Drawing.Color Interpret(TContext context) => Value;
    }
}