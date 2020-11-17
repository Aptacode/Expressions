using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Float
{
    public abstract class TernaryFloatExpression<TContext> : IFloatExpression<TContext>
    {
        protected TernaryFloatExpression(IBooleanExpression<TContext> condition,
            IFloatExpression<TContext> passExpression, IFloatExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IFloatExpression<TContext> PassExpression { get; }

        public IFloatExpression<TContext> FailExpression { get; }

        public abstract float Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}