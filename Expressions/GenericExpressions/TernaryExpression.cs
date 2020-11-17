using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class TernaryExpression<T1, T2, TContext> : IExpression<T2, TContext>
    {
        protected TernaryExpression(IExpression<T1, TContext> condition,
            IExpression<T2, TContext> passExpression, IExpression<T2, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<T1, TContext> Condition { get; }

        public IExpression<T2, TContext> PassExpression { get; }

        public IExpression<T2, TContext> FailExpression { get; }

        public abstract T2 Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}