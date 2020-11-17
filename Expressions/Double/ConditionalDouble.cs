using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Double
{
    public class ConditionalDouble<TContext> : TernaryDoubleExpression<TContext> 
    {
        public ConditionalDouble(IBooleanExpression<TContext> condition, IDoubleExpression<TContext> passExpression,
            IDoubleExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override double Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}