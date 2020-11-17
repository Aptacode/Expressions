using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Guid
{
    public abstract class TernaryGuidExpression<TContext> : IExpression<System.Guid, TContext>
    {
        protected TernaryGuidExpression(IExpression<bool, TContext> condition,
            IExpression<System.Guid, TContext> passExpression, IExpression<System.Guid, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<bool, TContext> Condition { get; }

        public IExpression<System.Guid, TContext> PassExpression { get; }

        public IExpression<System.Guid, TContext> FailExpression { get; }

        public abstract System.Guid Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}