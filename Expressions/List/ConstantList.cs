namespace Aptacode.Expressions.List
{
    /// <summary>
    ///     The class for a constant list expression containing expressions of any type.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConstantList<TType, TContext> : TerminalListExpression<TType, TContext>

    {
        public ConstantList(TType[] value)
        {
            Value = value;
        }

        public TType[] Value { get; }

        public override TType[] Interpret(TContext context)
        {
            return Value;
        }
    }
}