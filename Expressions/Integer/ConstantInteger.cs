namespace Aptacode.Expressions.Integer
{
    public class ConstantInteger<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        public ConstantInteger(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public int Interpret(TContext context) => Value;
    }
}