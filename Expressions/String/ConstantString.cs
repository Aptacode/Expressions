namespace Aptacode.Expressions.String
{
    public class ConstantString<TContext> : TerminalStringExpression<TContext> where TContext : IContext
    {
        public ConstantString(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override string Interpret(TContext context) => Value;
    }
}