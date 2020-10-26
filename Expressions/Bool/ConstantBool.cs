namespace Aptacode.Expressions.Bool
{
    public class ConstantBool<TContext> : IBooleanExpression<TContext> where TContext : IContext
    {
        public ConstantBool(bool value)
        {
            Value = value;
        }

        public bool Value { get; }

        public bool Interpret(TContext context) => Value;
    }
}