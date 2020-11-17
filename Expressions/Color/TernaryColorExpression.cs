using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Color
{
    public abstract class TernaryColorExpression<TContext> : IExpression<System.Drawing.Color, TContext>
    {
        protected TernaryColorExpression(IExpression<bool, TContext> condition,
            IExpression<System.Drawing.Color, TContext> passExpression, IExpression<System.Drawing.Color, TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IExpression<bool, TContext> Condition { get; }

        public IExpression<System.Drawing.Color, TContext> PassExpression { get; }

        public IExpression<System.Drawing.Color, TContext> FailExpression { get; }

        public abstract System.Drawing.Color Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}