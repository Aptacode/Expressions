using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean logical operator '<c>!</c>' on boolean expressions.
    /// </summary>
    public class Not<TContext> : UnaryExpression<bool, TContext>
    {
        public Not(IExpression<bool, TContext> expression) : base(expression)
        {
        }

        public override bool Interpret(TContext context)
        {
            return !Expression.Interpret(context);
        }
    }
}