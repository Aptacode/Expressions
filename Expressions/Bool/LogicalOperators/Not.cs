using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    public class Not<TContext> : UnaryExpression<bool, TContext>
    {
        public Not(IExpression<bool, TContext> expression) : base(expression) { }
        public override bool Interpret(TContext context) => !Expression.Interpret(context);
    }
}