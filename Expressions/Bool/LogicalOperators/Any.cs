using System.Linq;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    /// The class for the boolean conditional logical operator '<c>||</c>' for any amount of boolean expressions.
    /// </summary>
    public class Any<TContext> : NaryBoolExpression<TContext>
    {
        public Any(params IExpression<bool, TContext>[] expressions) : base(expressions) { }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(false,
                (current, booleanExpression) => current || booleanExpression.Interpret(context));
        }
    }
}