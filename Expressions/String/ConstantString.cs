namespace Aptacode.Expressions.String
{
    public class ConstantString<TContext> : IStringExpression<TContext> where TContext : IContext
    {
        public ConstantString(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public string Interpret(TContext context) => Value;
    }
}