using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Color
{
    public class ConditionalColor<TContext> : TernaryColorExpression<TContext> 
    {
        public ConditionalColor(IBooleanExpression<TContext> condition, IColorExpression<TContext> passExpression,
            IColorExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override System.Drawing.Color Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}