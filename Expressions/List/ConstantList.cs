namespace Aptacode.Expressions.List
{
    public class ConstantList<TType, TContext> : TerminalListExpression<TType, TContext>

    {
        public ConstantList(TType[] value)
        {
            Value = value;
        }

        public TType[] Value { get; }

        public override TType[] Interpret(TContext context) => Value;
    }
}