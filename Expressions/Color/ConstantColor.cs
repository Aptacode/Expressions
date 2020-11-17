namespace Aptacode.Expressions.Color
{
    public class ConstantColor<TContext> : TerminalColorExpression<TContext>
    {
        public ConstantColor(System.Drawing.Color value)
        {
            Value = value;
        }

        public System.Drawing.Color Value { get; }

        public override System.Drawing.Color Interpret(TContext context) => Value;
    }
}