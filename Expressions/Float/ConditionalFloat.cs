using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Float
{
    public class ConditionalFloat<TContext> : TernaryFloatExpression<TContext> 
    {
        public ConditionalFloat(IBooleanExpression<TContext> condition, IFloatExpression<TContext> passExpression,
            IFloatExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override float Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}