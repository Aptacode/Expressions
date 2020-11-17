using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Decimal
{
    public abstract class TernaryDecimalExpression<TContext> : IDecimalExpression<TContext>
    {
        protected TernaryDecimalExpression(IBooleanExpression<TContext> condition,
            IDecimalExpression<TContext> passExpression, IDecimalExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IDecimalExpression<TContext> PassExpression { get; }

        public IDecimalExpression<TContext> FailExpression { get; }

        public abstract decimal Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}