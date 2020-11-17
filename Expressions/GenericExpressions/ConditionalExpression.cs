namespace Aptacode.Expressions.GenericExpressions
{
    public class ConditionalExpression<TType, TContext> : TernaryExpression<bool, TType, TContext>
    {
        public ConditionalExpression(IExpression<bool, TContext> condition,
            IExpression<TType, TContext> passExpression, IExpression<TType, TContext> failExpression) : base(condition,
            passExpression, failExpression) { }

        public override TType Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}