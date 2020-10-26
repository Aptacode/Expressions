namespace Aptacode.Expressions.Bool
{
    public abstract class UnaryBoolExpression<TContext> : IBooleanExpression<TContext> where TContext : IContext
    {
        protected UnaryBoolExpression(IBooleanExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IBooleanExpression<TContext> Expression { get; }

        public abstract bool Interpret(TContext context);
    }
}