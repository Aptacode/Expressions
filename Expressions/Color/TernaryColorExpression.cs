using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Color
{
    public abstract class TernaryColorExpression<TContext> : IColorExpression<TContext> where TContext : IContext
    {
        protected TernaryColorExpression(IBooleanExpression<TContext> condition,
            IColorExpression<TContext> passExpression, IColorExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IColorExpression<TContext> PassExpression { get; }

        public IColorExpression<TContext> FailExpression { get; }

        public abstract System.Drawing.Color Interpret(TContext context);
    }
}