using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Decimal
{
    public class ConditionalDecimal<TContext> : TernaryDecimalExpression<TContext> 
    {
        public ConditionalDecimal(IBooleanExpression<TContext> condition, IDecimalExpression<TContext> passExpression,
            IDecimalExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override decimal Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}