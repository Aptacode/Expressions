using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.String
{
    public abstract class TernaryStringExpression<TContext> : IExpression<string, TContext>
    {
        protected TernaryStringExpression(IExpression<bool, TContext> condition,
            IExpression<string, TContext> passExpression, IExpression<string, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<bool, TContext> Condition { get; }

        public IExpression<string, TContext> PassExpression { get; }

        public IExpression<string, TContext> FailExpression { get; }

        public abstract string Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}