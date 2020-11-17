namespace Aptacode.Expressions.Double
{
    public class ConstantDouble<TContext> : TerminalDoubleExpression<TContext> 
    {
        public ConstantDouble(double value)
        {
            Value = value;
        }

        public double Value { get; }

        public override double Interpret(TContext context) => Value;
    }
}