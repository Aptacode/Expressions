namespace Aptacode.Expressions.Guid
{
    public class ConstantGuid<TContext> : IGuidExpression<TContext> where TContext : IContext
    {
        public ConstantGuid(System.Guid value)
        {
            Value = value;
        }

        public System.Guid Value { get; }

        public System.Guid Interpret(TContext context) => Value;
    }
}