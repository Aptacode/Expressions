using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TernaryListExpression<TType, TContext> : IListExpression<TType, TContext>

    {
        protected TernaryListExpression(IExpression<bool, TContext> condition,
            IListExpression<TType, TContext> passExpression, IListExpression<TType, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<bool, TContext> Condition { get; }

        public IListExpression<TType, TContext> PassExpression { get; }

        public IListExpression<TType, TContext> FailExpression { get; }

        public abstract TType[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}