using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Color
{
    public class ConditionalColor<TContext> : TernaryColorExpression<TContext>
    {
        public ConditionalColor(IExpression<bool, TContext> condition, IExpression<System.Drawing.Color, TContext> passExpression,
            IExpression<System.Drawing.Color, TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override System.Drawing.Color Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}