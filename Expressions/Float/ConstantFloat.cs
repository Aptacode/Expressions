namespace Aptacode.Expressions.Float
{
    public class ConstantFloat<TContext> : TerminalFloatExpression<TContext> 
    {
        public ConstantFloat(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public override float Interpret(TContext context) => Value;
    }
}