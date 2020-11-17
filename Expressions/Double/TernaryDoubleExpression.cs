using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Double
{
    public abstract class TernaryDoubleExpression<TContext> : IDoubleExpression<TContext>
    {
        protected TernaryDoubleExpression(IBooleanExpression<TContext> condition,
            IDoubleExpression<TContext> passExpression, IDoubleExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IDoubleExpression<TContext> PassExpression { get; }

        public IDoubleExpression<TContext> FailExpression { get; }

        public abstract double Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}