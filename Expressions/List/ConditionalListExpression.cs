

namespace Aptacode.Expressions.List
{
    public class ConditionalListExpression<TType, TContext> : TernaryListExpression<bool, TType, TContext>

    {
        public ConditionalListExpression(IExpression<bool, TContext> condition,
            IListExpression<TType, TContext> passExpression, IListExpression<TType, TContext> failExpression) : base(condition,
            passExpression, failExpression) { }


        public override TType[] Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}