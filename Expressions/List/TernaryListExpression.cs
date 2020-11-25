using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TernaryListExpression<T1, T2, TContext> : IListExpression<T2, TContext>

    {
        protected TernaryListExpression(IExpression<T1, TContext> condition,
            IListExpression<T2, TContext> passExpression, IListExpression<T2, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<T1, TContext> Condition { get; }

        public IListExpression<T2, TContext> PassExpression { get; }

        public IListExpression<T2, TContext> FailExpression { get; }

        public abstract T2[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}