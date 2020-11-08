namespace Aptacode.Expressions.List
{
    public abstract class UnaryListExpression<TContext> : IListExpression<TContext> where TContext : IContext
    {
        protected UnaryListExpression(IListExpression<TContext> value)
        {
            Value = value;
        }

        public IListExpression<TContext> Value { get; }

        public abstract int[] Interpret(TContext context);
    }
}