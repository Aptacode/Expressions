using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.String
{
    public abstract class TernaryStringExpression<TContext> : IStringExpression<TContext> 
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

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}