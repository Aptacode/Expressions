using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.String
{
    public abstract class TernaryStringExpression<TContext> : IStringExpression<TContext> where TContext : IContext
    {
        protected TernaryStringExpression(IBooleanExpression<TContext> condition,
            IStringExpression<TContext> passExpression, IStringExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IStringExpression<TContext> PassExpression { get; }

        public IStringExpression<TContext> FailExpression { get; }

        public abstract string Interpret(TContext context);
    }
}