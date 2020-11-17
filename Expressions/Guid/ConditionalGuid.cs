using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Guid
{
    public class ConditionalGuid<TContext> : TernaryGuidExpression<TContext>
    {
        public ConditionalGuid(IBooleanExpression<TContext> condition, IGuidExpression<TContext> passExpression,
            IGuidExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override System.Guid Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}