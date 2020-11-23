using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class ConditionalListExpression<TType, TContext> : TernaryListExpression<bool, TType, TContext>

    {
        protected ConditionalListExpression(IExpression<bool, TContext> condition,
            IListExpression<TType, TContext> passExpression, IListExpression<TType, TContext> failExpression) : base(condition,
            passExpression, failExpression)
        { }

        public override TType[] Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}