using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Integer
{
    public class Conditional<TContext> : TernaryIntegerExpression<TContext> 
    {
        public Conditional(IBooleanExpression<TContext> condition, IIntegerExpression<TContext> passExpression,
            IIntegerExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override int Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}