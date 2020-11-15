namespace Aptacode.Expressions.Integer
{
    public class ConstantInteger<TContext> : TerminalIntegerExpression<TContext> 
    {
        public ConstantInteger(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public override int Interpret(TContext context) => Value;
    }
}