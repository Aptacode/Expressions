using System.Linq;

namespace Aptacode.Expressions.Bool.LogicalOperators;

/// <summary>
///     The class for the boolean conditional logical operator '<c>&&</c>' for any amount of boolean expressions.
/// </summary>
public record All<TContext>
    (params IExpression<bool, TContext>[] Expressions) : NaryBoolExpression<TContext>(Expressions)
{
    public override bool Interpret(TContext context)
    {
        return Expressions.Aggregate(true,
            (current, booleanExpression) => current && booleanExpression.Interpret(context));
    }
}