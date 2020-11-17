using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Guid
{
    public class ConditionalGuid<TContext> : TernaryGuidExpression<TContext>
    {
        public ConditionalGuid(IExpression<bool, TContext> condition, IExpression<System.Guid, TContext> passExpression,
            IExpression<System.Guid, TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override System.Guid Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}