using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Integer
{
    public abstract class TernaryIntegerExpression<TContext> : IIntegerExpression<TContext>
    {
        protected TernaryIntegerExpression(IBooleanExpression<TContext> condition,
            IIntegerExpression<TContext> passExpression, IIntegerExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IIntegerExpression<TContext> PassExpression { get; }

        public IIntegerExpression<TContext> FailExpression { get; }

        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}