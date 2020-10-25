using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.Bool
{
    public class Conditional<TContext> : TernaryIntegerExpression<TContext> where TContext : IContext
    {
        public override int Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);

        public Conditional(IBooleanExpression<TContext> condition, IIntegerExpression<TContext> passExpression, IIntegerExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }
    }
}