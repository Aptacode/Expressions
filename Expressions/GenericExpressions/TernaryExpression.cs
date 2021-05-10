using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class TernaryExpression<T1, T2, TContext> : IExpression<T2, TContext>
    {
        public readonly IExpression<T1, TContext> Condition;

        public readonly IExpression<T2, TContext> FailExpression;

        public readonly IExpression<T2, TContext> PassExpression;

        protected TernaryExpression(IExpression<T1, TContext> condition,
            IExpression<T2, TContext> passExpression, IExpression<T2, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public abstract bool Equals(IExpression<T2, TContext> other);
        public abstract T2 Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}