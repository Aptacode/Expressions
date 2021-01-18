using System.Linq;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean conditional logical operator '<c>&&</c>' for any amount of boolean expressions.
    /// </summary>
    public class All<TContext> : NaryBoolExpression<TContext>
    {
        public All(params IExpression<bool, TContext>[] expressions) : base(expressions)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(true,
                (current, booleanExpression) => current && booleanExpression.Interpret(context));
        }
    }
}