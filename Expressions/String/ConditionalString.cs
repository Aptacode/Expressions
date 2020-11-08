using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.String
{
    public class ConditionalString<TContext> : TernaryStringExpression<TContext> where TContext : IContext
    {
        public ConditionalString(IBooleanExpression<TContext> condition, IStringExpression<TContext> passExpression,
            IStringExpression<TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override string Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}