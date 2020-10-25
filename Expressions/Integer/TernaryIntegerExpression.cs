using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Integer
{
    public abstract class TernaryIntegerExpression<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        protected TernaryIntegerExpression(IBooleanExpression<TContext> condition, IIntegerExpression<TContext> passExpression, IIntegerExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }
        public IBooleanExpression<TContext> Condition { get; }

        public IIntegerExpression<TContext> PassExpression { get; }

        public IIntegerExpression<TContext> FailExpression { get; }

        public abstract int Interpret(TContext context);
    }
}