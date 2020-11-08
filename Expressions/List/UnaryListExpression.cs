namespace Aptacode.Expressions.List
{
    public abstract class UnaryListExpression<TContext> : IListExpression<TContext> where TContext : IContext
    {
        protected UnaryListExpression(IListExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TContext> Expression { get; }

        public abstract int[] Interpret(TContext context);
    }
}