using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Color
{
    public class ConstantColor<TContext> : TerminalColorExpression<TContext> where TContext : IContext
    {
        public ConstantColor(System.Drawing.Color value)
        {
            Value = value;
        }

        public System.Drawing.Color Value { get; }

        public override System.Drawing.Color Interpret(TContext context) => Value;
    }
}