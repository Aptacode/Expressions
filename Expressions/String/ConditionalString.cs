using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.String
{
    public class ConditionalString<TContext> : TernaryStringExpression<TContext>
    {
        public ConditionalString(IExpression<bool, TContext> condition, IExpression<string, TContext> passExpression,
            IExpression<string, TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override string Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}