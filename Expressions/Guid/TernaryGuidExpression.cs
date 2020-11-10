using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Guid
{
    public abstract class TernaryGuidExpression<TContext> : IGuidExpression<TContext> where TContext : IContext
    {
        protected TernaryGuidExpression(IBooleanExpression<TContext> condition,
            IGuidExpression<TContext> passExpression, IGuidExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IGuidExpression<TContext> PassExpression { get; }

        public IGuidExpression<TContext> FailExpression { get; }

        public abstract System.Guid Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}