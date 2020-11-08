namespace Aptacode.Expressions.List
{
    public class ConstantList<TContext> : IListExpression<TContext> where TContext : IContext
    {
        public ConstantList(int[] value)
        {
            Value = value;
        }

        public int[] Value { get; }

        public int[] Interpret(TContext context) => Value;
    }
}